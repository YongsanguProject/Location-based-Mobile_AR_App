using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class EndingExplainClose : MonoBehaviour, IPointerClickHandler
{
    public EndingExplain ex;
    public RawImage ec;
    public EndingCharacter character;
    public void OnPointerClick(PointerEventData eventData)
    {
        ex.gameObject.SetActive(false);
        character.camerabtn = 1;
        character.morebtn = 0;
        ec.gameObject.SetActive(true);

    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
