using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle_In : MonoBehaviour {
    public GameObject vehicle1, vehicle2, vehicle3;
    float delta = -5f;
    // Use this for initialization
    void Start () {
        Transform vt1 = vehicle1.GetComponent<Transform>();
        vt1.position = new Vector3(3f, -1.329f, 4.868f);
        Transform vt2 = vehicle1.GetComponent<Transform>();
        vt2.position = new Vector3(3f, -0.949f, 5.761f);
        Transform vt3 = vehicle1.GetComponent<Transform>();
        vt3.position = new Vector3(3f, -0.458f, 6.548f);
    }

    void moveVehicle(GameObject Vehicle)
    {
        Transform t = Vehicle.GetComponent<Transform>();
        t.position = new Vector3(t.position.x + delta
                                 , t.position.y
                                 , t.position.z);
    }	

	// Update is called once per frame
	void Update () {
        /* vehicle1 : -0.49  -1.329  4.868
         * vehicle 2 : -0.0084  -0.949  5.761
         * vehicle3 : 0.668  -0.458  6.548*/
        Transform vt1 = vehicle1.GetComponent<Transform>();
        Transform vt2 = vehicle1.GetComponent<Transform>();
        Transform vt3 = vehicle1.GetComponent<Transform>();
        
        if (vt1.position.x >= -0.49f) moveVehicle(vehicle1);
        if (vt2.position.x >= -0.0084f) moveVehicle(vehicle2);
        if (vt3.position.x >= -0.668f) moveVehicle(vehicle3);

    }


}
