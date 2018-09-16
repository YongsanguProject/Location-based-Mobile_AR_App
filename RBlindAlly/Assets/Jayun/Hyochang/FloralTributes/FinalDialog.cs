using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FinalDialog : MonoBehaviour {

    public Drag dg;
    public Canvas gc;
    public Canvas mc;
    public Canvas dc;//Dialog Canvas
    public int page = 0;

    public Text NameText;
    public Text StoryText;

    public RawImage before;
    public RawImage next;

    public RawImage take;
    public RawImage pass;

    public RawImage kimgu;
    public RawImage bonggill;
    public RawImage junggeun;
    public RawImage bongchang;
    public RawImage jounggi;

	// Use this for initialization
	void Start () {
        dc.gameObject.SetActive(false);
        take.gameObject.SetActive(false);
        pass.gameObject.SetActive(false);

        kimgu.gameObject.SetActive(false);
        bonggill.gameObject.SetActive(false);
        junggeun.gameObject.SetActive(false);
        jounggi.gameObject.SetActive(false);
        bongchang.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

        Text nt = NameText.GetComponent<Text>();
        Text st = StoryText.GetComponent<Text>();

        if (!dg.dragging)
        {
            gc.gameObject.SetActive(false);
            mc.gameObject.SetActive(false);
            dc.gameObject.SetActive(true);

            if (page == 0)
            {
                before.gameObject.SetActive(false);
                next.gameObject.SetActive(true);
            }
            if (page == 2)
            {
                before.gameObject.SetActive(false);
                next.gameObject.SetActive(false);
                take.gameObject.SetActive(true);
                pass.gameObject.SetActive(true);
                st.text = "우리의 만남을 기념하며 사진 한 장 찍겠소?";
            }
            switch (SelectChar.charSelect)
            {
                case 1://김구
                    kimgu.gameObject.SetActive(true);
                    nt.text = "백범 김구";
                    if (page == 0)
                        st.text = "고맙소. 그대 덕분에 효창공원에 무궁화와 태극기가 만개했구려. \n오늘 그대가 피워준 무궁화와 태극기는 영원히 지지 않을 걸세.";
                    if (page == 1)
                    {
                        before.gameObject.SetActive(true);
                        st.text = "그럼, 앞으로도 종종 찾아주시게나.적적했던 효창공원이 그대의 존재만으로도 활기차지는 것 같구려.\n언제나 이곳에서 기다리겠소.";
                    }
                    break;
                case 2://윤봉길
                    bonggill.gameObject.SetActive(true);
                    nt.text = "윤봉길";
                    if (page == 0)
                        st.text = "태극의 깃발이 높이 드날리는 조국은 눈이 부시도록 아름답소. 비록 나의 시간은 멈추었으나 우리 자손들의 시간이, 대한의 시간이 굽이굽이 물결쳐 흐르는 모습이 아주 보기 좋소이다.";
                    if (page == 1)
                    {
                        before.gameObject.SetActive(true);
                        st.text = "고맙소. 쓸쓸한 내 무덤이 그대의 꽃으로 화사해졌구려.";
                    }
                    break;
                case 3://이봉창
                    bongchang.gameObject.SetActive(true);
                    nt.text = "이봉창";
                    if (page == 0)
                        st.text = "어서 오시게나. 해방된 조국, 해방된 용산에서 보니 꽤 반갑구려. 내 어릴 적 뛰놀던 이곳이 무궁화와 태극기로 수놓아진 광경을 보니, 마음이 들떠 마구 두근거리는구려.";
                    if (page == 1)
                    {
                        before.gameObject.SetActive(true);
                        st.text = "고맙소. 앞으로도 종종 찾아주시게나. 나는 언제나 이곳에서 그대를 기다리고 있으니.";
                    }
                    break;
                case 4: //안중근
                    bongchang.gameObject.SetActive(true);
                    nt.text = "안중근";
                    if (page == 0)
                        st.text = "꼭 돌아오고 싶소, 이 아름다운 강산에…….";
                    if (page == 1)
                    {
                        before.gameObject.SetActive(true);
                        st.text = "내 돌아올 그날까지 그대가 놓아준 이 꽃다발이 내 빈 무덤을 지키고 있을 걸세. 고맙소.";
                    }
                    break;
                case 5: //백정기
                    jounggi.gameObject.SetActive(true);
                    nt.text = "백정기";
                    if (page == 0)
                        st.text = "조국의 자주독립이 오거든 동지들의 손으로 해방된 조국 땅 어디든 묻히는 것이 소원이었소. \n마침내 내 무덤 위에 무궁화까지 놓이니 가슴이 벅차오르오.";
                    if (page == 1)
                    {
                        before.gameObject.SetActive(true);
                        st.text = "고맙소. 내 사는 동안 정처 없이 떠돌았지만, 독립한 조국을 보니 이제야 마음 놓고 편히 쉴 수 있겠구려.";
                    }
                    break;
            }
        }
	}
}
