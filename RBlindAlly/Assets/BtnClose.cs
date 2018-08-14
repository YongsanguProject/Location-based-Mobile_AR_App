using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BtnClose : MonoBehaviour, IPointerClickHandler
{
    public RawImage second;
    public RawImage btn_before;

    public RawImage openpaper;
    public OpenPaper op;
    public void OnPointerClick(PointerEventData eventData)
    {
        op.click_flag = 0;
        btn_before.gameObject.SetActive(false);
        second.gameObject.SetActive(false);
        openpaper.gameObject.SetActive(false);

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
