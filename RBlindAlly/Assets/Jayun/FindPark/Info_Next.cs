using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Info_Next : MonoBehaviour,IPointerClickHandler {

    public RawImage ParkInfo;
    public RawImage InfoMini;

    public void OnPointerClick(PointerEventData eventData)
    {
        Destroy(ParkInfo, 1f);
        RawImage rim = InfoMini.GetComponent<RawImage>();
        rim.enabled = true;
        Debug.Log("클릭됨");
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
