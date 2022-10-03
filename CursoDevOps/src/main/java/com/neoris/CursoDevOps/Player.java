package com.neoris.CursoDevOps;

import java.time.LocalDate;
import java.time.format.DateTimeFormatter;

public class Player {
	private String nombre;
	private String apellido;
	 private LocalDate cumpleanios;

	public Player(String nombre, String apellido, LocalDate cumpleanios) {
		this.nombre = nombre;
		this.apellido = apellido;
		 this.cumpleanios = cumpleanios;
		// DateTimeFormatter dtf = DateTimeFormatter.ofPattern("dd/mm/yyyy");
		// this.cumpleanios = cumpleanios.format(dtf);

	}

	@Override
	public String toString() {
		DateTimeFormatter dtf = DateTimeFormatter.ofPattern("dd/MM/yyyy");
		return "nombre: "+this.nombre+ " apellido: "+this.apellido+ " cumpleaños: "+this.cumpleanios.format(dtf);
	}

}
/*
 * Crear una API (web service) y que sus dependencias e infraestructura estén en
 * Docker. Debe exponer el recurso “/players” en el puerto 8081. La API debe
 * tener una carga inicial de al menos dos jugadores (distintos) sin utilizar
 * una base de datos
 * 
 * Definición de atributos para un “Player”:
 * 
 * Name: string
 * 
 * Last name: string
 * 
 * Birthday: int
 * 
 * La visualización del atributo birthday debe ser en formato dd/mm/yyyy)
 */