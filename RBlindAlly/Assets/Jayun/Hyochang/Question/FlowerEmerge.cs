using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlowerEmerge : MonoBehaviour {

   public GPSCheck gps;

    public GameObject flower_1;
    public GameObject flower_2;
    public GameObject flower_3;
    public GameObject flower_4;
    public GameObject flower_5;
    public GameObject flower_6;
    public GameObject flower_7;
    public string NextSceneString;
    public RandomQuiz rq;


    public int spotNum; //스팟 위치


	// Use this for initialization
	void Start () {
        flower_1.gameObject.SetActive(false);
        flower_2.gameObject.SetActive(false);
        flower_3.gameObject.SetActive(false);
        flower_4.gameObject.SetActive(false);
        flower_5.gameObject.SetActive(false);
        flower_6.gameObject.SetActive(false);
        flower_7.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update() {
        //문제 맞춘 개수 5개 이하일때만 꽃 등장
        if (rq.right_num < 5) { 
            if (GPSCheck.current_Lat>=10) {
                flower_1.gameObject.SetActive(true);
                spotNum = 0;
                //gps.lat >= 37.5454 && gps.lat <= 37.5456 && gps.lon >=126.9609 && gps.lon <= 126.9611
                //gps.lat >= 37.6785&& gps.lat <= 37.6787 && gps.lon >=126.7479 && gps.lon <= 126.7481
            }
            else if (rq.right_num == 1)
            {
                flower_2.gameObject.SetActive(true);
                spotNum = 1;
                //gps.lat >= 37.5446 && gps.lat <= 37.5448 && gps.lon >= 126.9600 && gps.lon <= 126.9602
            }
            else if (rq.right_num == 2)
            {
                flower_3.gameObject.SetActive(true);
                spotNum = 2;
                //gps.lat >= 37.5447 && gps.lat <= 37.5449 && gps.lon >= 126.9620 && gps.lon <= 126.9622
            }
            else if (rq.right_num == 3)
            {
                flower_4.gameObject.SetActive(true);
                spotNum = 3;
                //gps.lat >= 37.5448 && gps.lat <= 37.5450 && gps.lon >= 126.9606 && gps.lon <= 126.9608
            }
            else if (rq.right_num == 4)
            {
                flower_5.gameObject.SetActive(true);
                spotNum = 4;
                //gps.lat >= 37.5445 && gps.lat <= 37.5447 && gps.lon >= 126.9606 && gps.lon <= 126.9608
            }
            else if (rq.right_num == 5)
            {
                flower_6.gameObject.SetActive(true);
                spotNum = 5;
                //gps.lat >= 37.5441 && gps.lat <= 37.5443 && gps.lon >= 126.9627 && gps.lon <= 126.9629
            }
            else if (rq.right_num == 6)
            {
                flower_7.gameObject.SetActive(true);
                spotNum = 6;
                //gps.lat >= 37.5442 && gps.lat <= 37.5444 && gps.lon >= 126.9620 && gps.lon <= 126.9622
            }
            /*
                        if ((gps.lat >= 50))
                        {
                            flower_3.gameObject.SetActive(true);
                            spotNum = 2;
                        }

                        if ((gps.lat >= 50))
                        {
                            flower_4.gameObject.SetActive(true);
                            spotNum = 3;
                        }

                        if ((gps.lat >= 50))
                        {
                            flower_5.gameObject.SetActive(true);
                            spotNum = 4;
                        }

                        if ((gps.lat >= 50.67567))
                        {
                            flower_6.gameObject.SetActive(true);
                            spotNum = 5;
                        }

                        if ((gps.lat >= 55.67567))
                        {
                            flower_1.gameObject.SetActive(true);
                            spotNum = 6;
                        }*/
        }
        switch (spotNum)//한 장소에서 3번 틀린 경우
        {
            case 0:
                if (rq.countWrong[spotNum]== 2)
                    Destroy(flower_1);
                if (rq.getff)
                    Destroy(flower_1);
                break;
            case 1:
                if (rq.countWrong[spotNum] == 2)
                    Destroy(flower_2);
                
                if (rq.getff)
                    Destroy(flower_2);
                break;
            case 2:
                if (rq.countWrong[spotNum] == 2)
                    Destroy(flower_3);
                if (rq.getff)
                    Destroy(flower_3);
                break;
            case 3:
                if (rq.countWrong[spotNum] == 2)
                    Destroy(flower_4);
                if (rq.getff)
                    Destroy(flower_4);
                break;
            case 4:
                if (rq.countWrong[spotNum] == 2)
                    Destroy(flower_5);
                if (rq.getff)
                    Destroy(flower_5);
                break;
            case 5:
                if (rq.countWrong[spotNum] == 2)
                    Destroy(flower_6);
                if (rq.getff)
                    Destroy(flower_6);
                break;
            case 6:
                if (rq.countWrong[spotNum] == 2)
                    Destroy(flower_7);
                if (rq.getff)
                    Destroy(flower_7);
                break;
        }
        /*
        if (rq.getff)
        {
            if ((gps.lat >= 10))
            {
                Destroy(flower_1);
            }

            if ((gps.lat >= 10))
            {
                Destroy(flower_2);
            }

            if ((gps.lat >= 50))
            {
                Destroy(flower_3);
            }

            if ((gps.lat >= 43.67567))
            {
                Destroy(flower_4);
            }

            if ((gps.lat >= 45.67567))
            {
                Destroy(flower_5);
            }

            if ((gps.lat >= 50.67567))
            {
                Destroy(flower_6);
            }

            if ((gps.lat >= 55.67567))
            {
                Destroy(flower_7);
            }
        }
        */
        if (rq.right_num ==0)
        {
            if (GPSCheck.current_Lat >= 10) {
                Application.LoadLevel(NextSceneString);
            }
        }



            

    }
}
