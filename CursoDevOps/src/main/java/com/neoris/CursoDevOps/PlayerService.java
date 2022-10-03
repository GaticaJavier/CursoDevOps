package com.neoris.CursoDevOps;


import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

import org.springframework.stereotype.Service;

@Service
public class PlayerService {
	
	private List<Player> players;
	
	
	
	public List<String> getPlayers() {
		// TODO Auto-generated method stub
		players = new ArrayList<>();
		Player p1 = new Player("Pepe", "Coso", LocalDate.of(1995, 10, 3));
		players.add(p1);
		//players.add();
		//players.add(new Player("Josefina", "Coso", LocalDate.of(1990, 5, 15)) );
		return players.stream().map(player ->  player.toString()).collect(Collectors.toList());
	}

}
