using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragNet : MonoBehaviour
{
    Vector3 dist;
    float posX;
    float posY;
    public Catch_Box cb;
    public bool dragging = false;
    private void OnMouseDown()
    {
        dist = Camera.main.WorldToScreenPoint(transform.position);
        posX = Input.mousePosition.x - dist.x;
        posY = Input.mousePosition.y - dist.y;
    }

    private void OnMouseDrag()
    {
        if (dragging == true)
        {
            Vector3 curPos = new Vector3(Input.mousePosition.x - posX, Input.mousePosition.y - posY
                                    , dist.z);
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(curPos);
            transform.position = worldPos;
        }



    }

    private void OnTriggerEnter(Collider other)
    {
        if (dragging == true) { 
            if (other.tag == "Box")
                {
                    dragging = false;
                    cb.net_finish = true;
                }
        }
    }
    // Use this for initialization
    void Start()
    {
        dragging = false;

    }

    // Update is called once per frame
    void Update()
    {
    }
}
