using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PileTile : MonoBehaviour {
    //Loseta simple para las pilas
    public GameObject tilePrefab;    

    private float heightSeparation = 0.1f;
    private int maxTiles = 12;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < maxTiles; i++) {

            //Altura en y aumentada en 1f para que al momento de moverla no se superponga
            //sobre las fichas del mapa
            GameObject playerOne = (GameObject)Instantiate(tilePrefab, new Vector3(-1.016f, 1f + heightSeparation * i, 0.75f), Quaternion.identity);
            GameObject playerTwo = (GameObject)Instantiate(tilePrefab, new Vector3(6.73f, 1f + heightSeparation * i, 4.5f), Quaternion.identity);

            playerOne.name = "PO_Tile_" + i;
            playerTwo.name = "PT_Tile_" + i;

            playerOne.transform.SetParent(this.transform);
            playerTwo.transform.SetParent(this.transform);

            playerOne.GetComponentInChildren<Renderer>().material.color = Color.blue;
            playerTwo.GetComponentInChildren<Renderer>().material.color = Color.red;

            playerTwo.GetComponentInChildren<DragAndDrop>().player = 2;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
