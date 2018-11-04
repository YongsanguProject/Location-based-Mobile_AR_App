using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Info_Next : MonoBehaviour,IPointerClickHandler {

    public RawImage ParkInfo;
    public RawImage InfoMini;
    public RawImage MiniPark;
    public RawImage Button;
    public Text text1;
    public Text text2;
    public RawImage Park;
    public bool game_start = false;

    public void OnPointerClick(PointerEventData eventData)
    {
        Destroy(ParkInfo, 0.5f);
        Destroy(Button, 0.5f);
        Destroy(text1, 0.5f);
        Destroy(text2, 0.5f);
        Destroy(Park, 0.5f);
        RawImage rim = InfoMini.GetComponent<RawImage>();
        RawImage mp = MiniPark.GetComponent<RawImage>();
        rim.enabled = true;
        mp.enabled = true;
        game_start = true;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
