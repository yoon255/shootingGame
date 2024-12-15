using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteo : MonoBehaviour
{
    public GM sGM;
    public Rigidbody2D meteoRB;
    public float speed = 6f;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        meteoRB.velocity = new Vector2(0,-speed);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //바닥과 부딪혔을때, 목숨감소
        //= : <= 대입
        //==: 비교. 이게 맞니?
        if(collision.name == "floor")
        {
            //sGM.playerLife -= 1;
            sGM.playerLife--;
            sGM.ShowHeart();
            animator.SetTrigger("a");
        }
        if(collision.name == "player")
        {
            Debug.Log("플레이어파괴");
            //[오브젝트를 없애는 방법]
            //1. 실제로 없애기 : Destroy(삭제할 오브젝트);
            //Destroy(collision.gameObject);
            //[v]2. 없어진것처럼 보이기 : 게임오브젝트.SetActive(fasle);
            collision.gameObject.SetActive(false);
            animator.SetTrigger("a");
        }
    } 


}
