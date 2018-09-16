using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour {
    Vector3 dist;
    float posX;
    float posY;

    public bool dragging = true;
    public GameObject flower;
    private void OnMouseDown()
    {
        dist = Camera.main.WorldToScreenPoint(transform.position);
        posX = Input.mousePosition.x - dist.x;
        posY = Input.mousePosition.y - dist.y;
    }

    private void OnMouseDrag()
    {
        if (dragging)
        {
            Vector3 curPos = new Vector3(Input.mousePosition.x - posX, Input.mousePosition.y - posY
                                    , dist.z);
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(curPos);
            transform.position = worldPos;
            if (transform.position.y > 0.4f)
            {
               // Destroy(flower, 1.5f);
                dragging = false;
            }
                
        }
        

        
    }
    // Use this for initialization
    void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
        if (!dragging) gameObject.SetActive(false);
	}
}
