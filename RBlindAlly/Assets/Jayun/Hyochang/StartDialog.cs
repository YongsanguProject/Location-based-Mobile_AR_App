using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartDialog: MonoBehaviour {

    public WindBlow wb;
    public Canvas ca;
    public Canvas dc;
    public string NextSceneString;
    public RawImage before;
    public RawImage next;
    public RawImage DialogBubble;
    public Text BubbleText;
    public RawImage map;
    public Text st;
    public int page = 0;
    public GameObject tree;
    public Canvas gc;
    float time = 0f;
	// Use this for initialization
	void Start () {
        dc.gameObject.SetActive(false);
        DialogBubble.gameObject.SetActive(false);
        BubbleText.gameObject.SetActive(false);
        map.gameObject.SetActive(false);
        gc.gameObject.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {

        Text t = st.GetComponent<Text>();
        if (wb.start_dialog)
        {
            ca.gameObject.SetActive(false);
            dc.gameObject.SetActive(true);

            switch (page)
            {
                case 0:
                    t.text = "어이쿠! 예상치 못한 바람이……!";
                    before.gameObject.SetActive(false);
                    break;
                case 1:
                    t.text = "번거롭겠지만 흩어진 무궁화 태극기 꽃잎을 모아주시오.\n다 찾으면[효창공원 상징조형물] 앞에서 봅세.";
                    before.gameObject.SetActive(true);
                    break;
                case 2:
                    BubbleText.gameObject.SetActive(true);
                    DialogBubble.gameObject.SetActive(true);
                    map.gameObject.SetActive(true);
                    Destroy(tree);
                    before.gameObject.SetActive(false);
                    break;
                case 3:
                    dc.gameObject.SetActive(false);
                    gc.gameObject.SetActive(true);
                    time += Time.deltaTime;
                    if (time > 1.5f)
                    {
                        Application.LoadLevel(NextSceneString);
                    }
                    break;
            }

        }
	}
}
