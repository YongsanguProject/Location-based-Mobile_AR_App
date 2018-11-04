using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class CheckNotPark1 : MonoBehaviour, IPointerClickHandler{

    public CheckWrong cw;
    public AudioSource ParkSound2;
    public void OnPointerClick(PointerEventData eventData){
        cw.wrong3 = true;
        ParkSound2.GetComponent<AudioSource>().Play();
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
