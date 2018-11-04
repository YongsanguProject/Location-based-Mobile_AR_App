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
        if (GPSCheck.current_Lat >= 37.5450 && GPSCheck.current_Lat < 37.5452 && GPSCheck.current_Long >= 126.9596 && GPSCheck.current_Long <= 126.9598 && SelectChar.charSelect == 1)
        //GPSCheck.current_Lat >= 37.5451 && GPSCheck.current_Lat < 37.5453 && GPSCheck.current_Long >= 126.958 && GPSCheck.current_Long < 126.960 && SelectChar.charSelect == 1
        //백범김구37.545253, 126.959656
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

        } else if (SelectChar.charSelect!= 1 && GPSCheck.current_Lat >= 37.5451 && GPSCheck.current_Lat < 37.54535 && GPSCheck.current_Long >= 126.9613 && GPSCheck.current_Long < 126.9616) {
            //GPSCheck.current_Lat >= 37.5447 && GPSCheck.current_Lat < 37.54449 && GPSCheck.current_Long >= 126.960 && GPSCheck.current_Long < 126.962
            //그 외  37.544875, 126.96168
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
