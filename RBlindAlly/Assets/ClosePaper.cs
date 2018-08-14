using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class ClosePaper : MonoBehaviour, IPointerClickHandler
{
    public RawImage openpaper;
 

    public void OnPointerClick(PointerEventData eventData)
    {
        openpaper.gameObject.SetActive(true);
    }

    // Use this for initialization
    void Start () {
        openpaper.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

        }


}
