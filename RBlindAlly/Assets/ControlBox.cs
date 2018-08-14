using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlBox : MonoBehaviour {
    public Text Clicktext;
    public RawImage GetImage;

    // Use this for initialization
    void Start()
    {
        GetImage.gameObject.SetActive(false);

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
                
                GetImage.gameObject.SetActive(true);
                Clicktext.text = " ";
                Destroy(GetImage.gameObject,2.0f);






            }
        }

    }
}
