using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovingVehicle : MonoBehaviour {
    public RawImage Vehicle;
    public RawImage Vehicle2;
    public RawImage Vehicle3;
    float delta = 1f;
    int sound = 0;
    public bool is_stop;
    public bool destroy = false;
    public bool check;
    public int rot;
    public AudioSource vehicle_sound;
	// Use this for initialization
	void Start () {
 
        RectTransform t1 = Vehicle.GetComponent<RectTransform>();
        t1.position = new Vector3(2000f
                                 ,-100f
                                 , 0);
        RectTransform t2 = Vehicle2.GetComponent<RectTransform>();
        t2.position = new Vector3(2000f
                                 , 150f
                                 , 0);

        RectTransform t3 = Vehicle3.GetComponent<RectTransform>();
        t3.position = new Vector3(2000f
                                 , 450f
                                 , 0);

        is_stop = false;
        check = true;
        rot = 0;
    }
    void moveForward(RawImage veh)
    {
        RectTransform t = veh.GetComponent<RectTransform>();
        t.position = new Vector3(t.position.x - delta
                                , t.position.y
                                , 0);
        delta += 0.2f;
    }

    void stopping(RawImage veh)
    {
        RectTransform t = veh.GetComponent<RectTransform>();
        if (rot < 20 && check) {
            t.Rotate(0, 0, 0.5f);
            rot++;
        }else if (rot > 0)
        {
            check = false;
            t.Rotate(0, 0, -0.5f);
            rot--;
        }
        
    }
    // Update is called once per frame
    void Update () {
        RectTransform vt1 = Vehicle.GetComponent<RectTransform>();
        if (vt1.position.x >= 300f)
        {
            moveForward(Vehicle);
            if ( sound == 10) {
                vehicle_sound.GetComponent<AudioSource>().Play();
            }
            sound++;
            
        }
        else
        {
            stopping(Vehicle);
            is_stop = true;
            destroy = true;
        }

        RectTransform vt2 = Vehicle2.GetComponent<RectTransform>();
        if (vt2.position.x >= 600f) moveForward(Vehicle2);
        else stopping(Vehicle2);

        RectTransform vt3 = Vehicle3.GetComponent<RectTransform>();
        if (vt3.position.x >= 850f) moveForward(Vehicle3);
        else stopping(Vehicle3);
    }
}
