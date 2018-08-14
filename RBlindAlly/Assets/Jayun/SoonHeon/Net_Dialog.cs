using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Net_Dialog : MonoBehaviour {
    public RawImage NetInfo;
    public RawImage GetNet;
    public RawImage GetBox;
    public SelectBox_Pond box;
    public SelectNet net;
    public Text how_to;
    public Catch_Box cat;
    // Use this for initialization
    void Start()
    {
        RawImage ni = NetInfo.GetComponent<RawImage>();
        ni.enabled = false;

        RawImage gn = GetNet.GetComponent<RawImage>();
        gn.enabled = false;

        RawImage gb = GetBox.GetComponent<RawImage>();
        gb.enabled = false;
        Text t = how_to.GetComponent<Text>();
        t.enabled = false;
    }

    void Update()
    {
        if (net.catch_net)//뜰채 안내 메세지
        {
            RawImage gn = GetNet.GetComponent<RawImage>();
            gn.enabled = true;
            Destroy(GetNet, 2f);
            Text t = how_to.GetComponent<Text>();
            t.enabled = true;
        }

        if (box.is_click)//뜰채 획득 메세지
        {
            RawImage ni = NetInfo.GetComponent<RawImage>();
            ni.enabled = true;
            Destroy(NetInfo, 2f);
        }

      
        
    }
}
