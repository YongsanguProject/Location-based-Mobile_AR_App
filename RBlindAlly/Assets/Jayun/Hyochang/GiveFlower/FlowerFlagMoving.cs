using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class FlowerFlagMoving : MonoBehaviour, IDragHandler, IEndDragHandler{

    public BloomFlowerFlag bff;
    public Canvas bc;//BasketCanvas
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }
    
    public void OnEndDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
        bff.flowerCount++;
    }

    public void Update()
    {
        if (bff.flowerCount == 5) {
            bc.gameObject.SetActive(false);
            bff.is_select = false;
            
        }
    }

}
