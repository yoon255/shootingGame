using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D playerRB;
    [Range(-10,10)] public float speed = 6f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float hori =
        Input.GetAxis("Horizontal"); //좌우방향키, a,d키를 눌렀을때
                                     //-1(왼쪽) ~ 1(오른쪽) 값을 생성

        float verti =
        Input.GetAxis("Vertical"); //상하방향키, w,s키를 눌렀을때
                                   //-1(아래쪽) ~ 1(위쪽) 값을 생성

        playerRB.velocity = new Vector2() * speed;

        //[가정]
        //왼쪽방향키를 누름. hori = -1
        //playerRB.velocity = new Vector2(-1, 0)
        //왼쪽으로 이동

        //오른쪽방향키를 누름. hori = +1
        //playerRB.velocity = new Vector2(+1, 0)
        //오른쪽으로 이동
    }
}
