using UnityEngine;
using System.Collections;

public class Map : MonoBehaviour {

	public GameObject hexPrefab;

	// Size of the map in terms of number of hex tiles
	// This is NOT representative of the amount of 
	// world space that we're going to take up.
	// (i.e. our tiles might be more or less than 1 Unity World Unit)
	int width = 7;
	int height = 7;

	float xOffset = 0.882f;
	float zOffset = 0.764f;

	// Use this for initialization
	void Start () {
	
		for (int x = 0; x < width; x++) {
			for (int y = 0; y < height; y++) {

				float xPos = x * xOffset;

				// Are we on an odd row?
				if( y % 2 == 1 ) {
					xPos += xOffset/2f;
				}

				GameObject hex_go = (GameObject)Instantiate(hexPrefab, new Vector3( xPos,0, y * zOffset  ), Quaternion.identity  );

				// Name the gameobject something sensible.
				hex_go.name = "Hex_" + x + "_" + y;

				// Make sure the hex is aware of its place on the map
				hex_go.GetComponent<Position>().x = x;
				hex_go.GetComponent<Position>().y = y;
				GameManager.instance.mapTiles.Add(hex_go.GetComponent<Position>());

				// For a cleaner hierachy, parent this hex to the map
				hex_go.transform.SetParent(this.transform);

				// TODO: Quill needs to explain different optimization later...
				//hex_go.isStatic = true;

			}
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
