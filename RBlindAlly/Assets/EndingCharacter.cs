using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingCharacter : MonoBehaviour {
    public RawImage dialog;
    public RawImage character;
    public RawImage explain;

    public Text message;
    public Text message2;

    public RawImage docamera;
    public RawImage notcamera;

     float timer;
     int waitingTime;

    //다이얼로그
    public int morebtn = 0;
    public int camerabtn = 0;
    //////////////////////////////

    // Use this for initialization
    void Start () {
        timer = 0;
        waitingTime = 3;
        dialog.gameObject.SetActive(false);
        explain.gameObject.SetActive(false);
        message2.gameObject.SetActive(false);
        docamera.gameObject.SetActive(false);
        notcamera.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        if (timer > waitingTime)
        {
            dialog.gameObject.SetActive(true);
            //Action
            timer = 0;
        }

        if(morebtn == 1) //더보기 버튼(설명)
        {
            dialog.gameObject.SetActive(false);
            character.gameObject.SetActive(false);
            explain.gameObject.SetActive(true);

        }

        if(camerabtn == 1) //나가기 버튼(바로사진찍는부분)
        {
            dialog.gameObject.SetActive(false);
            message.gameObject.SetActive(false);

            message2.gameObject.SetActive(true);

            docamera.gameObject.SetActive(true);
            notcamera.gameObject.SetActive(true);
        }
    }
}
