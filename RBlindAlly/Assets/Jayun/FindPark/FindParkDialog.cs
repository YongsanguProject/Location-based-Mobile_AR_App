using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindParkDialog : MonoBehaviour {
    public MovingVehicle mv;
    public RawImage FindPark;
    public RawImage ParkInfo;
    public RawImage InfoMini;
    public RawImage Next_btn;
    int delta = 10;

    float infoTime = 0;
	// Use this for initialization
	void Start () {
		RawImage rfp = FindPark.GetComponent<RawImage>();
        rfp.enabled = false;

        RawImage rpi = ParkInfo.GetComponent<RawImage>();
        // rpi.enabled = false;

        RawImage rim = InfoMini.GetComponent<RawImage>();
        rim.enabled = false;

        RectTransform t = ParkInfo.GetComponent<RectTransform>();
        t.position = new Vector3(1100f
                                 , 3500f
                                 , 0);
    }
	

    void DropDown()
    {
        RawImage rpi = ParkInfo.GetComponent<RawImage>();
        rpi.enabled = true;

        RectTransform t = ParkInfo.GetComponent<RectTransform>();
        t.position = new Vector3(t.position.x
                                 , t.position.y - delta*2.3f
                                 , 0);
    }
	// Update is called once per frame
	void Update () {

        RawImage rfp = FindPark.GetComponent<RawImage>();
        RawImage rpi = ParkInfo.GetComponent<RawImage>();
        RawImage rim = InfoMini.GetComponent<RawImage>();

        RectTransform t = ParkInfo.GetComponent<RectTransform>();
        if (mv.is_stop)
        {

            rfp.enabled = true;

            if (mv.destroy)
            {
                Destroy(FindPark, 2.5f);
            }

            if ( t.position.y >= 1200f) DropDown();
        }

    }
}
