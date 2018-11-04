using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CheckPark : MonoBehaviour, IPointerClickHandler
{
    public string NextSceneString;
    public AudioSource ParkSound1;

    public void OnPointerClick(PointerEventData eventData)
    {
        ParkSound1.GetComponent<AudioSource>().Play();
        Application.LoadLevel(NextSceneString);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
