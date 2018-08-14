using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BtnBefore : MonoBehaviour, IPointerClickHandler
{
    public OpenPaper openpaper;
    public void OnPointerClick(PointerEventData eventData)
    {
        openpaper.click_flag = 0;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
