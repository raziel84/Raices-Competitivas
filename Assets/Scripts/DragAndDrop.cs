using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragAndDrop : MonoBehaviour
{
    private Vector3 mousePosition;
    private float heightSeparation = 0.1f;
    private bool posicionado = false;
    public int player = 1;

    //Losetas jugables
    public GameObject troncoPrefab;
    public GameObject bifYPrefab;
    public GameObject bifTPrefab;
    public GameObject puntSPrefab;
    public GameObject puntDPrefab;
    public GameObject raizCPrefab;
    public GameObject raizRPrefab;
    public GameObject trifCPrefab;
    public GameObject trifRPrefab;

    public Material mat_tronco;
    public Material mat_bifY;
    public Material mat_bifT;
    public Material mat_puntS;
    public Material mat_puntD;
    public Material mat_raizC;
    public Material mat_raizR;
    public Material mat_trifC;
    public Material mat_trifR;

    //transform.position hace referencia a la posicion del objeto seleccionado
    private Vector3 GetMousePos() {
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDown() {
        if (GameManager.instance.playerIndex != player) {
            return;
        }
        mousePosition = Input.mousePosition - GetMousePos();
        //Debug.Log("Mouse position " + mousePosition);
    }

    private void OnMouseDrag() {
        if (GameManager.instance.playerIndex != player) {
            return;
        }
        if (!posicionado) {

            Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition);

            //Cambia la malla del primer tile por la de la pieza principal
            if (transform.parent.name == "PO_Tile_11") {
                transform.GetComponentInChildren<MeshFilter>().mesh = troncoPrefab.GetComponentInChildren<MeshFilter>().sharedMesh;
                transform.GetComponentInChildren<Renderer>().material = troncoPrefab.GetComponentInChildren<Renderer>().sharedMaterial;
            }

            if (transform.parent.name == "PT_Tile_11") {
                transform.GetComponentInChildren<MeshFilter>().mesh = troncoPrefab.GetComponentInChildren<MeshFilter>().sharedMesh;
                transform.GetComponentInChildren<Renderer>().material = mat_tronco;
            }

            //Estos otros casos deberían resolver con un random
            if (transform.parent.name == "PO_Tile_0" ||
                transform.parent.name == "PO_Tile_5" ) {
                transform.GetComponentInChildren<MeshFilter>().mesh = raizRPrefab.GetComponentInChildren<MeshFilter>().sharedMesh;
                transform.GetComponentInChildren<Renderer>().material = raizRPrefab.GetComponentInChildren<Renderer>().sharedMaterial;
            }

            if (transform.parent.name == "PT_Tile_2" ||
                transform.parent.name == "PT_Tile_10") {
                transform.GetComponentInChildren<MeshFilter>().mesh = raizRPrefab.GetComponentInChildren<MeshFilter>().sharedMesh;
                transform.GetComponentInChildren<Renderer>().material = mat_raizR;
            }

            if (transform.parent.name == "PO_Tile_2" ||
                transform.parent.name == "PO_Tile_8" ) {
                transform.GetComponentInChildren<MeshFilter>().mesh = raizCPrefab.GetComponentInChildren<MeshFilter>().sharedMesh;
                transform.GetComponentInChildren<Renderer>().material = raizCPrefab.GetComponentInChildren<Renderer>().sharedMaterial;
            }

            if (transform.parent.name == "PT_Tile_0" ||
                transform.parent.name == "PT_Tile_5") {
                transform.GetComponentInChildren<MeshFilter>().mesh = raizCPrefab.GetComponentInChildren<MeshFilter>().sharedMesh;
                transform.GetComponentInChildren<Renderer>().material = mat_raizC;
            }

            if (transform.parent.name == "PO_Tile_1" ) {
                transform.GetComponentInChildren<MeshFilter>().mesh = bifYPrefab.GetComponentInChildren<MeshFilter>().sharedMesh;
                transform.GetComponentInChildren<Renderer>().material = bifYPrefab.GetComponentInChildren<Renderer>().sharedMaterial;
            }

            if (transform.parent.name == "PT_Tile_6") {
                transform.GetComponentInChildren<MeshFilter>().mesh = bifYPrefab.GetComponentInChildren<MeshFilter>().sharedMesh;
                transform.GetComponentInChildren<Renderer>().material = mat_bifY;
            }

            if (transform.parent.name == "PO_Tile_3" ) {
                transform.GetComponentInChildren<MeshFilter>().mesh = trifRPrefab.GetComponentInChildren<MeshFilter>().sharedMesh;
                transform.GetComponentInChildren<Renderer>().material = trifRPrefab.GetComponentInChildren<Renderer>().sharedMaterial;
            }

            if (transform.parent.name == "PT_Tile_4") {
                transform.GetComponentInChildren<MeshFilter>().mesh = trifRPrefab.GetComponentInChildren<MeshFilter>().sharedMesh;
                transform.GetComponentInChildren<Renderer>().material = mat_trifR;
            }

            if (transform.parent.name == "PO_Tile_4" ||
                transform.parent.name == "PO_Tile_10" ) {
                transform.GetComponentInChildren<MeshFilter>().mesh = puntSPrefab.GetComponentInChildren<MeshFilter>().sharedMesh;
                transform.GetComponentInChildren<Renderer>().material = puntSPrefab.GetComponentInChildren<Renderer>().sharedMaterial;
            }

            if (transform.parent.name == "PT_Tile_3" ||
                transform.parent.name == "PT_Tile_9") {
                transform.GetComponentInChildren<MeshFilter>().mesh = puntSPrefab.GetComponentInChildren<MeshFilter>().sharedMesh;
                transform.GetComponentInChildren<Renderer>().material = mat_puntS;
            }

            if (transform.parent.name == "PO_Tile_6" ) {
                transform.GetComponentInChildren<MeshFilter>().mesh = puntDPrefab.GetComponentInChildren<MeshFilter>().sharedMesh;
                transform.GetComponentInChildren<Renderer>().material = puntDPrefab.GetComponentInChildren<Renderer>().sharedMaterial;
            }

            if (transform.parent.name == "PT_Tile_7") {
                transform.GetComponentInChildren<MeshFilter>().mesh = puntDPrefab.GetComponentInChildren<MeshFilter>().sharedMesh;
                transform.GetComponentInChildren<Renderer>().material = mat_puntD;
            }

            if (transform.parent.name == "PO_Tile_7" ) {
                transform.GetComponentInChildren<MeshFilter>().mesh = trifCPrefab.GetComponentInChildren<MeshFilter>().sharedMesh;
                transform.GetComponentInChildren<Renderer>().material = trifCPrefab.GetComponentInChildren<Renderer>().sharedMaterial;
            }

            if (transform.parent.name == "PT_Tile_1") {
                transform.GetComponentInChildren<MeshFilter>().mesh = trifCPrefab.GetComponentInChildren<MeshFilter>().sharedMesh;
                transform.GetComponentInChildren<Renderer>().material = mat_trifC;
            }

            if (transform.parent.name == "PO_Tile_9" ) {
                transform.GetComponentInChildren<MeshFilter>().mesh = bifTPrefab.GetComponentInChildren<MeshFilter>().sharedMesh;
                transform.GetComponentInChildren<Renderer>().material = bifTPrefab.GetComponentInChildren<Renderer>().sharedMaterial;
            }

            if (transform.parent.name == "PT_Tile_8") {
                transform.GetComponentInChildren<MeshFilter>().mesh = bifTPrefab.GetComponentInChildren<MeshFilter>().sharedMesh;
                transform.GetComponentInChildren<Renderer>().material = mat_bifT;
            }

            transform.parent.position = new Vector3(newPosition.x, transform.parent.position.y, newPosition.z);

        }

    }

    private void OnMouseUp() {
        if (GameManager.instance.playerIndex != player) {
            return;
        }
        Ray ray = new Ray(transform.parent.position, Vector3.down);

        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo)) {
            GameObject outHitTileMap = hitInfo.collider.transform.parent.gameObject;

            //Debug.Log("Clicked On: " + ourHitObject.name);

            if (true) {

            }

            if (outHitTileMap.GetComponent<Position>() != null) {

                transform.parent.position = outHitTileMap.transform.position + Vector3.up * heightSeparation;
                posicionado = true;
                GameManager.instance.changeTurn();
                
            }

        }
    }

    
}
