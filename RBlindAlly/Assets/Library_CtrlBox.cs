using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Library_CtrlBox : MonoBehaviour {
    public Library_box_Tracking lbt;
    
 
    public GameObject library_box;
    public GameObject a1;
    public GameObject a2;

    public Text grass;
    public Text box;


	// Use this for initialization
	void Start () {
        library_box.gameObject.SetActive(false);
        grass.gameObject.SetActive(false);
        box.gameObject.SetActive(false);
      
	}
	
	// Update is called once per frame
	void Update () {

        if (lbt.is_detected_l)
        {
            grass.gameObject.SetActive(true);
        }else
        {
            grass.gameObject.SetActive(false);
            box.gameObject.SetActive(false);
        }

        if (lbt.grass>70)
        {
            a1.gameObject.SetActive(false);
            a2.gameObject.SetActive(false);
            library_box.gameObject.SetActive(true);

            grass.gameObject.SetActive(false);
            box.gameObject.SetActive(true);

        }
        
		
	}
}
