package com.neoris.CursoDevOps;


import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class PlayerController {

	@Autowired
	private PlayerService service;
	
	@GetMapping(value = "/players")
	public List<String> getPlayers() {
		//return this.service.getPlayers();
		return this.service.getPlayers();
	}
}
