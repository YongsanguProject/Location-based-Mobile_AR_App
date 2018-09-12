using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPerson : MonoBehaviour {
    //select person 고르기
    public Canvas gc;   //guide canvas
    public Canvas mc;   //map canvas

    public RawImage kmb;//KimguMapBtn
    public RawImage emb;//EtcMapBtn
   
	// Use this for initialization
	void Start () {
        mc.gameObject.SetActive(false);
        emb.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		//MoveGuide수정하기(김구일때 그 외일때), MapBtn도 수정하기


	}
}
