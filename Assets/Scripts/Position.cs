using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Position : MonoBehaviour {

	// Our coordinates in the map array
	public int x;
	public int y;
	//Var que te diga si está ocupado
	//var que te diga la pieza que lo ocupa
	//lista de piezas que la pueden ocupar
	//variables para guardar inicio, fin y si esto es parte de un camino

	public List<Position> GetNeighbours() {

		List<Position> neighbours = new List<Position>();

		// So if we are at x, y -- the neighbour to our left is at x-1, y
		GameObject left = GameObject.Find("Hex_" + (x-1) + "_" + y);
			if (left != null)
			neighbours.Add(left.GetComponent<Position>());
		GameObject right = GameObject.Find("Hex_" + (x+1) + "_" + y);
			if (right != null)
			neighbours.Add(left.GetComponent<Position>());
		GameObject rightUp = GameObject.Find("Hex_" + (x + 1) + "_" + (y + 1));
			if (rightUp != null)
			neighbours.Add(left.GetComponent<Position>());
		GameObject rightDown = GameObject.Find("Hex_" + (x + 1) + "_" + (y - 1));
			if (rightDown != null)
			neighbours.Add(left.GetComponent<Position>());
		GameObject leftUp = GameObject.Find("Hex_" + (x - 1) + "_" + (y + 1));
			if (leftUp != null)
			neighbours.Add(left.GetComponent<Position>());
		GameObject leftDown = GameObject.Find("Hex_" + (x - 1) + "_" + (y - 1));
			if (leftDown != null)
			neighbours.Add(left.GetComponent<Position>());

		return neighbours;
	}

	//metodo que llame al getneigh y te setee la var de ocupables de los vecinos en base 
	//al ocupado de acá, de manera tal que si pusiste un tronco, habilitas todos los vecinos
	//si pusiste otra pieza, habilites los correspondientes


	//metodo para chequear si al poner esta pieza completaste un camino y si es asi 
	//lo puntue y si cooresponde finalice el juego y llame a quien sea que esdte encargado de definir el ganador
}
