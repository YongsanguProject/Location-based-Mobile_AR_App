using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveVehicle : MonoBehaviour {
    float delta = -10f;
    public GameObject Vehicle;
    // Use this for initialization
    void Start () {
        //Transform vt1 = GetComponent<Transform>();
        //vt1.position = new Vector3(3f, -1.329f, 4.868f);
    }

    void movingVehicle()
    {


        Transform t = Vehicle.GetComponent<Transform>();
        t.position = new Vector3(t.position.x
                                 , t.position.y
                                 , t.position.z+delta);
    }

    // Update is called once per frame
    void Update()
    {
        /* vehicle1 : -0.49  -1.329  4.868
         * vehicle 2 : -0.0084  -0.949  5.761
         * vehicle3 : 0.668  -0.458  6.548*/

        Transform t = Vehicle.GetComponent<Transform>();
        if (t.position.x >= -0.49f)
        {
            movingVehicle();
        }

    }
}
