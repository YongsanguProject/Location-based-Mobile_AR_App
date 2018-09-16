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

    public RawImage arrow;
    public MoveFlower mf;
    float time = 0f;
	// Use this for initialization
	void Start () {
        mc.gameObject.SetActive(false);
        arrow.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        //MoveGuide수정하기(김구일때 그 외일때), MapBtn도 수정하기
        Text mg = moveGuide.GetComponent<Text>();
        if (GPSCheck.current_Lat >= 10 && SelectChar.charSelect == 1)    //백범김구
        {
            mg.text = "상석을 비추시오";
            
            mc.gameObject.SetActive(false);
            kmb.gameObject.SetActive(false);
            emb.gameObject.SetActive(false);

           
            time += Time.deltaTime;
            if (time >= 1.5f )
            {
                mg.text = "꽃다발을 끌어 상석에 헌화 하시오.";
                arrow.gameObject.SetActive(true);
                Destroy(moveGuide, 1.5f);
                Destroy(arrow, 1.5f);
                mf.is_emerge = true;
            }

        } else if (GPSCheck.current_Lat >= 10) {                          //그 외
            mg.text = "상석을 비추시오";

            mc.gameObject.SetActive(false);
            kmb.gameObject.SetActive(false);
            emb.gameObject.SetActive(false);


            time += Time.deltaTime;
            if (time >= 1.5f)
            {
                mg.text = "꽃다발을 끌어 상석에 헌화 하시오.";
                arrow.gameObject.SetActive(true);
                Destroy(moveGuide, 1.5f);
                Destroy(arrow, 1.5f);
                mf.is_emerge = true;
            }
        } else if (SelectChar.charSelect == 1)
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
