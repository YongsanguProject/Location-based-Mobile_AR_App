using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class EtcMapBtn : MonoBehaviour, IPointerClickHandler
{
    public Canvas mc;
    public RawImage map;

    public void OnPointerClick(PointerEventData eventData)
    {
        mc.gameObject.SetActive(true);
        map.gameObject.SetActive(true);
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
