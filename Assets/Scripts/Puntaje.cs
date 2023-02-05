using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour {

    public Button btnIncremento;
    public Button btnDecremento;
    public Text texto;
    private int puntaje = 0;

    // Start is called before the first frame update
    void Start()
    {
        btnIncremento.onClick.AddListener(Incremento);
        btnDecremento.onClick.AddListener(Decremento);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Incremento() {
        puntaje++;
        texto.text = puntaje.ToString();
    }
    private void Decremento() {
        puntaje--;
        texto.text = puntaje.ToString();
    }


}
