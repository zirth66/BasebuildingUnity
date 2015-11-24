using UnityEngine;
using System.Collections;

public class Tile {

	public enum TileType { Empty, Floor };

	TileType type = TileType.Empty;

	LooseObject looseObject;
	InstalledObject installedObject;

	World world;
	//coordinates in the world
	int x; 
	int y;

	/*constructor (Konstruktorn är metoden som anropas när du gör ett nytt objekt. 
	#Så det passar bra för initialiseringar och sånt.  Man måste alltid ha en konstruktor,
	#om du inte gör en själv så skapas en default konstruktor som inte tar några argument alls. )*/
	public Tile( World world, int x, int y) {
		this.world = world;
		this.x = x;
		this.y = y;
	}
}
