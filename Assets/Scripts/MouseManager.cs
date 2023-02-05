using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class MouseManager : MonoBehaviour
{

    private float heightSeparation = 0.1f;
    private GameObject tileSelected;

    // Update is called once per frame
    void Update() {

        // Is the mouse over a Unity UI Element?
        //if(EventSystem.current.IsPointerOverGameObject()) {
        // It is, so let's not do any of our own custom
        // mouse stuff, because that would be weird.

        // NOTE!  We might want to ask the system WHAT KIND
        // of object we're over -- so for things that aren't
        // buttons, we might not actually want to bail out early.

        //	return;
        //}
        // could also check if game is paused?
        // if main menu is open?

        //Debug.Log( "Mouse Position: " + Input.mousePosition );

        // This only works in orthographic, and only gives us the
        // world position on the same plane as the camera's
        // near clipping play.  (i.e. It's not helpful for our application.)
        //Vector3 worldPoint = Camera.main.ScreenToWorldPoint( Input.mousePosition );
        //Debug.Log( "World Point: " + worldPoint );

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo)) {
            tileSelected = hitInfo.collider.transform.parent.gameObject;

            //Debug.Log("Clicked On: " + ourHitObject.name);
            
            if (tileSelected.GetComponent<Hex>() != null) {
                
                MouseOver_Hex(tileSelected);
            }

        }

    }

    void MouseOver_Hex(GameObject ourHitObject) {
        //Debug.Log("Raycast hit: " + ourHitObject.name);

        if (Input.GetMouseButtonDown(0)) {

            MeshRenderer mr = ourHitObject.GetComponentInChildren<MeshRenderer>();

            if (mr.material.color == Color.red) {
                mr.material.color = Color.white;
            }
            else {
                mr.material.color = Color.red;            }

        }

        if (Input.GetMouseButtonUp(0)) {
            Debug.Log("Mouse UP: " + ourHitObject.name);
            tileSelected.transform.Translate(Camera.main.ScreenToWorldPoint(Input.mousePosition));

            Ray ray = new Ray(ourHitObject.transform.position, Vector3.back);

            RaycastHit hitInfo;

            if (Physics.Raycast(ray, out hitInfo)) {
                GameObject outHitTileMap = hitInfo.collider.transform.parent.gameObject;

                //Debug.Log("Clicked On: " + ourHitObject.name);
          
                if (outHitTileMap.GetComponent<Position>() != null) {
                    
                    ourHitObject.transform.position = outHitTileMap.transform.position + new Vector3(0f, heightSeparation, 0f);
                }


            }
        }

    }

    private void OnMouseDrag() {
        tileSelected.transform.Translate(Camera.main.ScreenToWorldPoint(Input.mousePosition));
    }


}
