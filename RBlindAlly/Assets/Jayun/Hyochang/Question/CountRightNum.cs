using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountRightNum : MonoBehaviour {
    public Text countNum;
    public RandomQuiz rq;
    public GPSCheck gps;
    public RawImage allflowerflag;
    public Text allgetText;

    float time = 0f;
	// Use this for initialization
	void Start () {
        //나중에 게임 시작 시 숫자 나타나도록 수정할 것..
        //  countNum.gameObject.SetActive(false);


        allflowerflag.gameObject.SetActive(false);
        allgetText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update() {

        Text cn = countNum.GetComponent<Text>();
     
        switch (rq.right_num)
        {
            case 0:
                cn.text = "( 0 / 5 )";
                break;
            case 1:
                cn.text = "( 1 / 5 )";
                
                break;
            case 2:
                cn.text = "( 2 / 5 )";
                
               
                break;
            case 3:
                cn.text = "( 3 / 5 )";
                
                break;
            case 4:
                cn.text = "( 4 / 5 )";
                break;
            case 5:
                cn.text = "( 5 / 5 )";
                if (time < 1.5f)
                {
                    allflowerflag.gameObject.SetActive(true);
                    allgetText.gameObject.SetActive(true);
                    time += Time.deltaTime;
                }
                else
                {
                    Text ag = allgetText.GetComponent<Text>();
                    allgetText.text = "[효창공원 상징조형물] 앞으로 가시오.";
                }
                //Application.LoadLevel(NextSceneString);
                break;
            case 6:
                break;
        }
    }
}
