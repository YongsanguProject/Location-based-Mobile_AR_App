using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CheckNotPark2 : MonoBehaviour, IPointerClickHandler{

    public CheckWrong cw;
    public AudioSource ParkSound3;
    public void OnPointerClick(PointerEventData eventData)
    {
        ParkSound3.GetComponent<AudioSource>().Play();
        cw.wrong2 = true;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
