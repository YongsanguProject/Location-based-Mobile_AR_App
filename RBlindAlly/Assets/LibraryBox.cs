using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LibraryBox : MonoBehaviour {
    public RawImage getimg;
    public Text box;
    public GameObject imgtg;

	// Use this for initialization
	void Start () {
        getimg.gameObject.SetActive(false);
		
	}

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.name == "Box")
            {

                Destroy(hit.transform.gameObject);        //물체 사라짐

                getimg.gameObject.SetActive(true);
                box.gameObject.SetActive(false);
                imgtg.SetActive(false);
                Destroy(getimg.gameObject, 2.0f);

            }
        }

 

    }
}
