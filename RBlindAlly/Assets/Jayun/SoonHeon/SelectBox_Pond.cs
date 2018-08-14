using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectBox_Pond : MonoBehaviour {

    public bool is_appear = true;   //상자가 나타나있는지 사라졌는지 다른 스크립트에서 활용하기 위한 변수
  //  public NetMoving obj_net;
    public bool is_click;
    // Use this for initialization
    void Start(){
        is_click = false;
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.name == "Soonheon_Box")
            {
                is_click = true;
            }
        }
    }
}
