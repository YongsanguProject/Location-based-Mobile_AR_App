using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Net_Moving : MonoBehaviour {

    float delta = 5f;//매 프레임마다 움직일 양

    public bool get_net;
    public SelectBox_Pond box;
    public SelectNet net;
	// Use this for initialization
	void Start () {

       get_net = false;
       MeshRenderer m = GetComponent<MeshRenderer>();
       m.enabled = false;
    }
	//
    void moveControl()
    {
        if (!net.catch_net)
        {
            Transform t = GetComponent<Transform>();
            t.position = new Vector3(t.position.x + delta
                                     ,95.5f
                                     ,t.position.z+delta);

            if (t.position.x >= -50 && t.position.x <=100)
            {
                delta = -delta;
            }
            if (t.position.x < -400)
            {
                System.Random random = new System.Random();
                float randomY = random.Next(-200, 400);
                t.position = new Vector3(250
                                        , 95.5f
                                        , randomY);
            }
            if (t.position.x > 400)
            {
                System.Random random = new System.Random();
                float randomY = random.Next(-300, 300);
                t.position = new Vector3(-400
                                        , 95.5f
                                        , randomY);
            }
        }
        else
        {
            Transform t = GetComponent<Transform>();
            get_net = true;
            t.position = new Vector3(-300, 95.5f, 0);
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        MeshRenderer m = GetComponent<MeshRenderer>();
        if (box.is_click){       //뜰채 나타남
            m.enabled = true;
            moveControl();
        }



    }
}
