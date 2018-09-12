using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class SelectJungGeun : MonoBehaviour, IPointerClickHandler
{
    public BloomFlowerFlag bff;
    public TombstoneDialog tb;

    public void OnPointerClick(PointerEventData eventData)
    {
        bff.is_select = true;
        tb.charSelect = 4;
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
