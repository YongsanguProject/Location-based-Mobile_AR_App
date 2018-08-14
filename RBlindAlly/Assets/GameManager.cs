using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Text timeLabel;
    public float timeCount = 0;
    public int r = 0;
    public int minute = 0;
    public int second = 0;
    public float flag = 0.0f;

    void Awake()
    {
        timeCount = 120; //2분
        
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (timeCount > 0)
        {
            timeCount -= Time.deltaTime;
            r = int.Parse(string.Format("{0:N0}", timeCount));
            minute = r/60;
            second = r % 60;
            if (minute < 10&&second >10 )
            {
                timeLabel.text ="0"+ minute.ToString() + " : " + second.ToString();
            }else if(minute > 10 && second < 10)
            {
                timeLabel.text = minute.ToString() + " : " + "0"+second.ToString();
            }else if (minute < 10 && second < 10)
            {
                timeLabel.text = "0" + minute.ToString() + " : " + "0" + second.ToString();
            }else
            {
                timeLabel.text = minute.ToString() + " : " + second.ToString();
            }
            flag += 0.8f;
          
        }
        else if (timeCount == 0)
        {
            minute = 0;
            second = 0;
            timeLabel.text = "0"+minute.ToString()+" : "+"0"+second.ToString();
            flag = 100f;
        }
      


    }
}
