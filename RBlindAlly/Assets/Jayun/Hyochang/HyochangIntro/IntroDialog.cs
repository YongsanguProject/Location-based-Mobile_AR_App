using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class IntroDialog : MonoBehaviour {

    public Text story;
    public int page = 0;

    public Canvas mc;
    public string NextSceneString;
    public Canvas guide;
    public Canvas dc;//dialog canvas
    public RawImage before;
    public RawImage next;
	// Use this for initialization
	void Start () {
        guide.gameObject.SetActive(false);
        mc.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        Text st = story.GetComponent<Text>();
        
        switch (page)
        {
            case 0:
                st.text = "이곳은 대한의 독립을 위해 나와 함께 뜻을 모았던 동지들이 잠들어 있는 곳이라오.";
                before.gameObject.SetActive(false);
                break;
            case 1:
                st.text = "일제의 계략으로 공원으로 전락한 이곳을 되살리고자 독립운동가들을 모셨지만, 세월이 지나면서 점점 젊은이들에게 잊히고 있다오.";
                before.gameObject.SetActive(true);
                break;
            case 2:
                st.text = "쓸쓸히 묻혀 있는 우리의 묘에 꽃을 피워 주시겠소?\n효창공원 안에 있는[의열사]에서 그대를 기다리고 있겠소.";
                break;
            case 3:
                guide.gameObject.SetActive(true);
                dc.gameObject.SetActive(false);
                if (GPSCheck.current_Lat >= 37.5449 && GPSCheck.current_Lat <= 37.5452 && GPSCheck.current_Long >= 126.959 && GPSCheck.current_Long <= 126.961)      //37.545069, 126.960717
                {
                    //GPSCheck.current_Lat >= 37.5449 && GPSCheck.current_Lat <= 37.5452 && GPSCheck.current_Long >= 126.959 && GPSCheck.current_Long <= 126.961
                    Application.LoadLevel(NextSceneString);
                }
                break;
        }
	}
}
