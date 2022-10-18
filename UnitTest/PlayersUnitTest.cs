using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PlayersAPI.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace UnitTest
{
    [TestClass]
    public class PlayersUnitTest
    {
        Mock<IPlayerRepository> playerRepository;

        [TestInitialize]
        public void Init()
        {
            playerRepository = new Mock<IPlayerRepository>();
        }

        [TestMethod]
        public void Should_Return_List_Of_Players()
        {
            var data = new List<Player>
            {
                new Player("1", "Name A", "Lastname A", 19880609),
                new Player("2", "Name B", "Lastname B", 20001225),
                new Player("3", "Name C", "Lastname C", 19860915)
            };
            
            playerRepository.Setup(a => a.ListPlayers()).Returns(data);

            var service = new PlayerService(playerRepository.Object);
            var listPlayers = service.GetPlayers();

            playerRepository.Verify(r => r.ListPlayers());
        }

        [TestMethod]
        public void Birthday_Should_Be_Converted_Properly_Date()
        {
            var data = new List<Player>
            {
                new Player("1", "Name A", "Lastname A", 19880609)
            };

            playerRepository.Setup(a => a.ListPlayers()).Returns(data);

            var service = new PlayerService(playerRepository.Object);
            var player = service.GetPlayers().ToList().FirstOrDefault();
            
            Assert.IsTrue(DateTime.ParseExact(data[0].Birthday.ToString(), "yyyyMMdd", CultureInfo.InvariantCulture).Equals(player.Birthday));
        }
    }
}
