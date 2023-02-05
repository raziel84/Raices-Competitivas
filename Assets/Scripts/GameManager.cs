using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager instance;
    public int playerIndex = 0;
    public Text playerOne;
    public Text playerTwo;
    //serializedfield tmpro jugador actual
    public List<Position> mapTiles = new List<Position>();

    private void Awake() {
        instance = this;
    }

    public void SetPlayerIndex() => playerIndex = 1;

    public void changeTurn() {
        if (playerIndex == 0) {
            return;
        }

        playerIndex = playerIndex == 1 ? 2 : 1;
        StartCoroutine(Turnos());
        //jugadoractual.text = $"Jugador actual: {playerIndex}";
    }

    private IEnumerator Turnos() {
        if (playerIndex == 1)
            playerOne.gameObject.SetActive(true);
        else
            playerTwo.gameObject.SetActive(true);

        yield return new WaitForSeconds(1f);

        if (playerIndex == 1)
            playerOne.gameObject.SetActive(false);
        else
            playerTwo.gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        playerOne.color = Color.blue;
        playerTwo.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
