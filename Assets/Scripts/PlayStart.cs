using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayStart : MonoBehaviour {

    public Button btn;
    public GameObject puntaje;

    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(Inicio);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Inicio() {
        gameObject.SetActive(false);
        puntaje.SetActive(true);
    }
}
