using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {
    public float speed = 1.0f;
    Transform trans;
    bool move = false;
    public Library_box_Tracking lbt;
  

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (move)
        {
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
            {

                Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
                trans.Translate(touchDeltaPosition.x * speed, 0, 0);
                lbt.grass += 1;
         
                move = false;

            }
        }
       
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "Cube1")
                {
                    Debug.Log(hit.transform.name);

                    trans = hit.transform;
                    move = true;
                }
                else if (hit.transform.name == "Cube2")
                {
                    Debug.Log(hit.transform.name);
                    trans = hit.transform;
                    move = true;
                }
                else if (hit.transform.name == "Cube3")
                {
                    Debug.Log(hit.transform.name);
                    trans = hit.transform;
                    move = true;
                }
                else if (hit.transform.name == "Cube4")
                {
                    Debug.Log(hit.transform.name);
                    trans = hit.transform;
                    move = true;
                }

            }

        

     

    }

}
