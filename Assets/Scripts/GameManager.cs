using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;
    public int playerIndex = 1;
    //serializedfield tmpro jugador actual
    public List<Position> mapTiles = new List<Position>();

    private void Awake() {
        instance = this;
    }

    public void changeTurn() {
        playerIndex = playerIndex == 1 ? 2 : 1;
        //jugadoractual.text = $"Jugador actual: {playerIndex}";
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
