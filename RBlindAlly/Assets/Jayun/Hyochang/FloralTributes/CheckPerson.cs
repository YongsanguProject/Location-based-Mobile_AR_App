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

    public Text moveGuide;
    public SelectChar sc;

	// Use this for initialization
	void Start () {
        mc.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        //MoveGuide수정하기(김구일때 그 외일때), MapBtn도 수정하기
        Text mg = moveGuide.GetComponent<Text>();
        if(SelectChar.charSelect == 0)
        {
            mg.text = "[백범 김구 묘역]으로 이동하시오";
            kmb.gameObject.SetActive(true);
        }
        else
        {
            mg.text = "[삼의사 묘역]으로 이동하시오";
            emb.gameObject.SetActive(true);
        }
	}
}
