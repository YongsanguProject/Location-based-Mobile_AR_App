using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;
using UnityEngine.Events;

public class BoxSelect : MonoBehaviour{

    public bool is_appear = true;   //상자가 나타나있는지 사라졌는지 다른 스크립트에서 활용하기 위한 변수
    // Use this for initialization
    void Start() {
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            if (hit.transform.name == "Sundarae_Box")
            {
                Destroy(gameObject);        //물체 사라짐
                is_appear = false;
            }
        }
    }
    /*
    // Update is called once per frame
    void Update() {
        if (Input.touchCount >= 1){
            var touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began){   //터치하면
                Destroy(gameObject);        //물체 사라짐
                is_appear = false;
            }
                
        }
	}

     */
}
