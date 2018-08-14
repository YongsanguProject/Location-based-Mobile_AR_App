using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.name == "Cube")
            {

                Destroy(hit.transform.gameObject);        //물체 사라짐

            }
        }

  

    }
}
