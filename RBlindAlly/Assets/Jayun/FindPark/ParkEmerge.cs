using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParkEmerge : MonoBehaviour {
    public RawImage RealPark;
    public RawImage NotPark1;
    public RawImage NotPark2;

    float delta = 10f;
    public int count;
    public bool check;

    public FindParkDialog fpd;
	// Use this for initialization
	void Start () {
        RectTransform rp = RealPark.GetComponent<RectTransform>();
        rp.position = new Vector3(800f
                                 , -50f
                                 , 0);

        RectTransform np1 = NotPark1.GetComponent<RectTransform>();
        np1.position = new Vector3(1100f
                                 , 200f
                                 , 0);

        RectTransform np2 = NotPark2.GetComponent<RectTransform>();
        np2.position = new Vector3(1350f
                                 , 500f
                                 , 0);

        count = 0;
        check = true;
    }
	
    void MovingPark(RawImage park){

        RectTransform pr = park.GetComponent<RectTransform>();
        for ( count = 0; count < 20; count++)
        {
            pr.position = new Vector3(pr.position.x
                                     , pr.position.y + delta
                                     , 0);
        }
        for (count = 20; count > 0 ; count--)
        {
            pr.position = new Vector3(pr.position.x
                                     , pr.position.y - delta
                                     , 0);
        }


    }
	// Update is called once per frame
	void Update () {
        
        if (fpd.game_start)
        {
            RawImage rrp = RealPark.GetComponent<RawImage>();
            rrp.enabled = true;

            RawImage rnp1 = NotPark1.GetComponent<RawImage>();
            rnp1.enabled = true;

            RawImage rnp2 = NotPark2.GetComponent<RawImage>();
            rnp2.enabled = true;


            System.Random random = new System.Random();
            int num = random.Next(0, 2);


            switch (num)
            {
                case 0:
                    MovingPark(RealPark);
                    break;
                case 1:
                    MovingPark(NotPark1);
                    break;
                case 2:
                    MovingPark(NotPark2);
                    break;
            }
        }

        
    }
}
