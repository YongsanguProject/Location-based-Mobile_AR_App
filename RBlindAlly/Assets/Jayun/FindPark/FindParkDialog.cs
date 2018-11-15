using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindParkDialog : MonoBehaviour {
    public MovingVehicle mv;
    public RawImage FindPark;
    public Text text1;//FindPark
    public Text text2;//FindPark
    public RawImage ParkInfo;
    public Text text3;//ParkInfo
    public Text text4;//ParkInfo
    public RawImage InfoMini;
    public RawImage Next_btn;
    public RawImage MiniPark;
    int delta = 10;

    public bool drop = false;

    public AudioSource dropdownsound;

    float infoTime = 0;
	// Use this for initialization
	void Start () {
		RawImage rfp = FindPark.GetComponent<RawImage>();
        rfp.enabled = false;

        Text t1 = text1.GetComponent<Text>();
        Text t2 = text2.GetComponent<Text>();
        t1.enabled = false;
        t2.enabled = false;
        Text t3 = text3.GetComponent<Text>();
        Text t4 = text4.GetComponent<Text>();
        t3.enabled = false;
        t4.enabled = false;
        RawImage rpi = ParkInfo.GetComponent<RawImage>();
        // rpi.enabled = false;

        RawImage rim = InfoMini.GetComponent<RawImage>();
        rim.enabled = false;
        RawImage mp = MiniPark.GetComponent<RawImage>();
        mp.enabled = false;

        RectTransform t = ParkInfo.GetComponent<RectTransform>();
        t.position = new Vector3(1100f
                                 , 3500f
                                 , 0);
    }
	

    void DropDown()
    {
        if (!drop){
            dropdownsound.GetComponent<AudioSource>().Play();
            drop = true;
        }

        RawImage rpi = ParkInfo.GetComponent<RawImage>();
        rpi.enabled = true;
        Text t3 = text3.GetComponent<Text>();
        Text t4 = text4.GetComponent<Text>();
        t3.enabled = true;
        t4.enabled = true;
        RectTransform t = ParkInfo.GetComponent<RectTransform>();
        t.position = new Vector3(t.position.x
                                 , t.position.y - delta*2.3f
                                 , 0);
    }
	// Update is called once per frame
	void Update () {
        Text t1 = text1.GetComponent<Text>();
        Text t2 = text2.GetComponent<Text>();
        RawImage rfp = FindPark.GetComponent<RawImage>();
        RawImage rpi = ParkInfo.GetComponent<RawImage>();
        RectTransform t = ParkInfo.GetComponent<RectTransform>();
        if (mv.is_stop)
        {
            rfp.enabled = true;
            t1.enabled = true;
            t2.enabled = true;
            if (mv.destroy)
            {
                Destroy(FindPark, 2.5f);
                Destroy(text1, 2.5f);
                Destroy(text2, 2.5f);
            }

            if ( t.position.y >= 1200f) DropDown();
        }

    }
}
