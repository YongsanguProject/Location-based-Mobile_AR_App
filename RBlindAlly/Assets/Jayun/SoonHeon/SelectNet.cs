using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SelectNet : MonoBehaviour {

    //public bool is_appear = true; 
    // Use this for initialization

    public bool catch_net;
    void Start()
    { 
        catch_net = false;
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.tag == "Net")
            {
                catch_net = true;       //뜰채 획득
            }
        }
    }
}
