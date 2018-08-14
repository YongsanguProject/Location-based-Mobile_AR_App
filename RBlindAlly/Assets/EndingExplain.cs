using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingExplain : MonoBehaviour {
    public Text explain;
    public Text explain2;

    public RawImage beforebtn;
    public RawImage nextbtn;
   

    public int is_next = 0;


	// Use this for initialization
	void Start () {
        explain2.gameObject.SetActive(false);
        beforebtn.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

        if(is_next == 1)
        {
            explain2.gameObject.SetActive(true);
            beforebtn.gameObject.SetActive(true);
            explain.gameObject.SetActive(false);
            nextbtn.gameObject.SetActive(false);

        }else
        {
            explain.gameObject.SetActive(true);
            beforebtn.gameObject.SetActive(false);
            explain2.gameObject.SetActive(false);
            nextbtn.gameObject.SetActive(true);
        }
		
	}
}
