using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenPaper : MonoBehaviour
{
    public RawImage btn_cancel;
    public RawImage btn_next;
    public RawImage btn_before;

    public Text first;
    public RawImage second;

    public int click_flag = 0;

    // Use this for initialization
    void Start () {
        btn_before.gameObject.SetActive(false);
        second.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

        if(click_flag == 1)
        {
            first.gameObject.SetActive(false);
            second.gameObject.SetActive(true);
            btn_next.gameObject.SetActive(false);
            btn_before.gameObject.SetActive(true);
        }else
        {
            btn_next.gameObject.SetActive(true);
            first.gameObject.SetActive(true);
            btn_before.gameObject.SetActive(false);
            second.gameObject.SetActive(false);
        }
       

	
	}
}
