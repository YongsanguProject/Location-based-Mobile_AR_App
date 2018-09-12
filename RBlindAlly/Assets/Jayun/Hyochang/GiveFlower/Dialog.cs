using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour {

    public Canvas sc; //Select Canvas
    public RawImage NextBtn;
    public RawImage BeforeBtn;
    public Canvas dc; //Dialog Canvas
    public Text text; //Dialog Text

    public int page = 0;

	// Use this for initialization
	void Start () {
        sc.gameObject.SetActive(false);
        BeforeBtn.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		Text tx = text.GetComponent<Text>();
        if (page == 0)
        {
            tx.text = "효창공원에는 다섯 명의 독립운동가를 기리는 무궁화나무가 있소.";
            BeforeBtn.gameObject.SetActive(false);
        }
        else if (page == 1)
        {
            tx.text = "이 중 한 그루를 선택해 꽃을 피워주시게나.";
            BeforeBtn.gameObject.SetActive(true);
        }else if (page == 2)
        {
            dc.gameObject.SetActive(false);
            sc.gameObject.SetActive(true);
        }

	}
}
