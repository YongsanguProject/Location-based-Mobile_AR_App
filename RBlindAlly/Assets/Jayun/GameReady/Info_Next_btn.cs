using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Info_Next_btn : MonoBehaviour,IPointerClickHandler{
    public Btn_Control bc;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (bc.page < 6)
        {
            bc.page++;
        }
    }
        // Use this for initialization
        void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
