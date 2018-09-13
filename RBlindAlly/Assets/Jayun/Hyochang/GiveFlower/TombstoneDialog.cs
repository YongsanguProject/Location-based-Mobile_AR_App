using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TombstoneDialog : MonoBehaviour {
    public Canvas tb; //TombstoneCanvas
    public Text tombText;
    public RawImage nextBtn;
    public RawImage beforeBtn;
    public Canvas gb;//GetBouquet Canvas
    public RawImage getBouquet;

    public BloomFlowerFlag bff;
    public GameObject ff;
    public GameObject tree;


    public RawImage kimgu;
    public RawImage bonggill;
    public RawImage bongchang;
    public RawImage junggeun;
    public RawImage junggi;

    public Text bouquetName;
    public Text bouquetText;
    public int page = 0;

    public bool endDialog = false;//비석대화끝\
    //public int charSelect = 0;  //1 : 김구, 2 : 윤봉길 3:이봉창 4: 안중근 5 : 백정기
	// Use this for initialization
	void Start () {
        tb.gameObject.SetActive(false);
        beforeBtn.gameObject.SetActive(false);
        gb.gameObject.SetActive(false);
        kimgu.gameObject.SetActive(false);
        bonggill.gameObject.SetActive(false);
        bongchang.gameObject.SetActive(false);
        junggeun.gameObject.SetActive(false);
        junggi.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        Text tt = tombText.GetComponent<Text>();
        Text nt = bouquetName.GetComponent<Text>();
        if (bff.bloom)
        {
            tb.gameObject.SetActive(true);
            switch (SelectChar.charSelect)
            {
                case 1:
                    if (page == 0) tt.text = "김구의 시선으로 꽃 한 송이를 본다.";
                    if (page == 1)
                    {
                        gb.gameObject.SetActive(true);
                        Destroy(getBouquet, 1.5f);
                        Destroy(tb);
                        Destroy(tree);
                        Destroy(ff);
                        endDialog = true;
                        kimgu.gameObject.SetActive(true);
                        nt.text = "백범 김구";
                    }
                    break;
                case 2:
                    if (page == 0) { 
                        tt.text = "1932년 4월 29일 오전 11시 40분 윤봉길은 상하이 홍커우 공원에서 일제 침략자들에게 폭탄을 던져 세계를 격동시켰다. ";
                        beforeBtn.gameObject.SetActive(false);
                    }
                    else if (page == 1)
                    {
                        beforeBtn.gameObject.SetActive(true);
                        tt.text = "2015년 4월 29일 오전 11시 40분 그 뜻을 기려 여기 무궁화를 심고 쇠에 글을 새기고 시간을 고정한다.";
                    } else if (page == 2)
                    {
                        gb.gameObject.SetActive(true);
                        Destroy(getBouquet, 1.5f);
                        Destroy(tb);
                        Destroy(tree);
                        Destroy(ff);
                        endDialog = true;
                        bonggill.gameObject.SetActive(true);
                        nt.text = "윤봉길";
                    }

                    break;
                case 3:
                    if (page == 0){
                        tt.text = "소년 이봉창이 뛰고 놀던 효창공원에 터를 닦아 꽃은 땅에, 우리 가슴에는 잔디를 심는다. ";
                        beforeBtn.gameObject.SetActive(false);
                    }
                    else if (page == 1)
                    {
                        beforeBtn.gameObject.SetActive(true);
                        tt.text = "살아서 이 고향 언덕으로 돌아오지 못한 그의 눈물 한 방울을 찍어 여기 새긴다.";
                    }else if (page == 2)
                    {
                        gb.gameObject.SetActive(true);
                        Destroy(getBouquet, 1.5f);
                        Destroy(tb);
                        Destroy(tree);
                        Destroy(ff);
                        endDialog = true;
                        bongchang.gameObject.SetActive(true);
                        nt.text = "이봉창";
                    }
                    break;
                case 4:
                    if (page == 0){
                        tt.text = "안중근은 하얼빈 역에서 이토 히로부미를 쓰러뜨렸다. 그날 쏜 단총은 벨기에제 브라우닝 총기번호 262336이었다. ";
                        beforeBtn.gameObject.SetActive(false);
                    }
                    else if (page == 1){
                        beforeBtn.gameObject.SetActive(true);
                        tt.text = "유해가 돌아올 때까지 빈 무덤에 꽃을 심고 땅 밑에 이 뜨거운 숫자를 묻는다.";
                    }else if (page == 2){
                        gb.gameObject.SetActive(true);
                        Destroy(getBouquet, 1.5f);
                        Destroy(tb);
                        Destroy(tree);
                        Destroy(ff);
                        endDialog = true;
                        junggeun.gameObject.SetActive(true);
                        nt.text = "안중근";
                    }
                    break;
                case 5:
                    if (page == 0){
                        tt.text = "모자 하나의 영토\n모자 하나의 대지\n모자 하나의 하늘";
                        beforeBtn.gameObject.SetActive(false);
                    }
                    else if (page == 1)
                    {
                        beforeBtn.gameObject.SetActive(true);
                        tt.text = "중절모 하나에 의지해 망명 혁명가로 살다 간 백정기의 이름으로 나무 한 그루의 영토에 꽃 한 송이를 심고 대지에 모자를 씌운다.";
                    }
                    else if (page == 2)
                    {
                        gb.gameObject.SetActive(true);
                        Destroy(getBouquet, 1.5f);
                        Destroy(tb);
                        Destroy(tree);
                        Destroy(ff);
                        endDialog = true;
                        junggi.gameObject.SetActive(true);
                        nt.text = "백정기";
                    }
                    break;
            }
        }

        if (endDialog)
        {
            Text bt = bouquetText.GetComponent<Text>();
            if (SelectChar.charSelect == 1)
            {
                bt.text = "무궁화 나무에 꽃을 피워주어 고맙소. 꽃다발을 가지고 백범김구 묘역에 헌화 해주시오.";
}
            else
            {
                bt.text = "무궁화 나무에 꽃을 피워주어 고맙소. 꽃다발을 가지고 삼의사 묘역에 헌화 해주시오.";
            }
        }
	}
}
