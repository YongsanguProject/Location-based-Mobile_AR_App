using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving3 : MonoBehaviour {

    Vector3 moveDirection = new Vector3(0.0f, 0.0f, 0.0f);  //방향 ..
    Vector3 beforePosition = new Vector3(0.0f, 0.0f, 0.0f); //hit된 오브젝트의 포지션 저장할 변수..
    float moveSpeed = 0.01f;  //이동스피드..
    bool moveGo = false;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (moveGo)
        {
            Move();
        }

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 1000.0f))
        {
            if (hit.collider.gameObject.tag == "Maingrass1")
            {
                if (Input.GetMouseButton(0))
                {
                    moveDirection = (hit.collider.gameObject.transform.position - transform.position); //방향을 정해주고..//
                    beforePosition = hit.collider.gameObject.transform.position;   //객체가 가야할 포지션을 저장해주고//
                    moveGo = true;            //무브 함수를 실행시키고 //

                }
            }
        }
    }

    void Move()
    {
        if (transform.position == beforePosition)
        {
            moveGo = false;
        }
        else
        {
            transform.position += moveDirection * moveSpeed;
        }
    }


}
