using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomQuiz : MonoBehaviour
{
    public Touch_Flower tf;
    
    public FlowerEmerge fe;

    public Canvas rcv;//retry Canvas
    public Canvas cv;//문제 나오는 canvas
    public Canvas cv_answer;//정답-획득
    public Text text;

    public Text qtext;
    public RawImage right;
    public RawImage wrong;
    public RawImage getBtn;
    public RawImage nextBtn;

    public RawImage retryBtn;
    public RawImage moveBtn;

    public Text retryText;
    int num = 0;
    public bool qlock = false;


    public int right_num = 0;       //정답 맞춘 개수
    bool answerb;
    public bool getff = false;
    public bool next = false;
    public bool checkAnswer;
    float time = 0f;
    float move_time = 0f;
    public bool respond = false;
    string[] quiz = {"효창공원의 원래 명칭은 효창원이다.", "효창공원은 독립운동가들의 정신을 기리고 있다.","일제강점기 효창공원은 일본에 의해 수난을 겪었다.",
        "효창공원에 묻힌 독립운동가는 8명이다.","삼의사는 이봉창, 윤봉길, 백정기 의사를 일컫는다.",
        "이봉창 의사는 1932년 도쿄에서 일왕 히로히토에게 수류탄을 투척했다.","이봉창 의사는 1932년 도쿄에서 일왕 히로히토에게 수류탄을 투척해 암살에 성공했다." };

    bool[] answer = { true, true, true, false, true, true, false }; //정답

    bool[] check = { false, false, false, false, false, false, false };   //나왔던 문제인지 체크

    public int[] countWrong = { 0, 0, 0, 0, 0, 0, 0 };     //틀린 개수 (3번 틀리면 그 스팟에서 문제 못 품)

    string[] explain = { "효창공원은 조선 22대 왕 정조의 맏아들인 문효세자의 무덤이 있어 효창원이라 불렸다.", "1946년 해방 이후 백범 김구 선생이 독립운동가들을 직접 효창공원으로 안장시키면서 효창공원은 독립운동가들의 숭고한 정신을 기리는 공간이 되었다.",
    "조선 왕실의 묘역이었던 효창공원은 일제강점기에 민족말살정책의 일환으로 일반 공원으로 전락했다.", "효창공원에는 임시정부의 김구, 이동녕, 차이석, 조성환과 윤봉길, 이봉창, 백정기 총 7명의 애국지사들이 안장되어 있다. 안중근 의사는 유해가 발견되지 않아 가묘만 존재한다.",
    "조국 광복을 위해 몸 바친 이봉창, 윤봉길, 백정기 의사를 삼의사라 일컫는다.","한인 애국단의 단원이었던 이봉창 의사는 관병식을 마치고 돌아가던 일와 히로히토를 겨냥하여 수류탄을 던져 우리의 독립의지를 보여 주었다.",
    "한인 애국단의 일원이었던 이봉창 의사는 관병식을 마치고 돌아가던 일왕 히로히토를 겨냥하여 수류탄을 던졌지만, 히로히토는 다치지 않아 거사는 실패로 돌아갔다. "};
    // Use this for initialization
    void Start()
    {
        Text qt = qtext.GetComponent<Text>();
        qt.text = "문        제";
        cv_answer.gameObject.SetActive(false);
        getBtn.gameObject.SetActive(false);
        nextBtn.gameObject.SetActive(false);
        rcv.gameObject.SetActive(false);
        cv.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (tf.is_touch)
        {
            if (qlock)
            {     //문제등장
                cv.gameObject.SetActive(true);
                Text qt = qtext.GetComponent<Text>();
                qt.text = "문        제";
                right.gameObject.SetActive(true);
                wrong.gameObject.SetActive(true);
                System.Random random = new System.Random();
                num = random.Next(0, quiz.Length);
                if (!check[num])            //아직 나오지않은 문제면
                {
                    Text t = text.GetComponent<Text>();
                    check[num] = true;
                    answerb = answer[num];
                    t.text = quiz[num];
                    qlock = false;          //문제 반복되지않도록 qlock끄기
                }

            }
        }

        if (respond)//답을 고른 경우
        {
            if (answerb == checkAnswer)//정답
            {
                Text qt = qtext.GetComponent<Text>();
                qt.text = "정        답";
                right.gameObject.SetActive(false);
                wrong.gameObject.SetActive(false);
                getBtn.gameObject.SetActive(true);
                rcv.gameObject.SetActive(false);
                if (getff)      //꽃 줍기
                {
                    cv.gameObject.SetActive(false);
                    cv_answer.gameObject.SetActive(true);   //꽃잎획득 canvas
                    getBtn.gameObject.SetActive(false);
                    time += Time.deltaTime;
                    if (time > 1.5f)
                    {
                        getff = false;
                        right_num++;            //정답개수
                        respond = false;        //대답여부
                        cv_answer.gameObject.SetActive(false);
                    }
                }

                Text t = text.GetComponent<Text>();
                t.text = explain[num];

            }
            else //오답
            {
                Text qt = qtext.GetComponent<Text>();
                qt.text = "오        답";
                right.gameObject.SetActive(false);
                wrong.gameObject.SetActive(false);
                nextBtn.gameObject.SetActive(true);
                Text t = text.GetComponent<Text>();
                t.text = explain[num];

                if (next)
                {
                    cv.gameObject.SetActive(false);
                    rcv.gameObject.SetActive(true);     //Retry Canvas(다시도전)
                    Text rt = retryText.GetComponent<Text>();

                    if (countWrong[fe.spotNum] < 2)
                    {       //재도전 
                        countWrong[fe.spotNum]++;
                        next = false;
                        nextBtn.gameObject.SetActive(false);
                        respond = false;
                        rt.text = "다른 문제를 풀어보시겠소? \n 아니면 다른 장소에서 찾아보시겠소?";
                    }
                    else
                    {
                        rt.text = "안타깝지만 여기서는 줍지 못할 것 같군……. 다른 장소로 가봅시다.";
                        retryBtn.gameObject.SetActive(false);
                        moveBtn.gameObject.SetActive(false);
                        tf.is_touch = false;        //꽃 다시 선택가능하도록(다른 위치 꽃)
                        if (move_time < 1.5f)
                        {
                            
                            move_time += Time.deltaTime;
                        }
                        else { rcv.gameObject.SetActive(false);}
                    }

                }

            }



        }
    }
}
