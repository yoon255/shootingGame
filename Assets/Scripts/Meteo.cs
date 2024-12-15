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
        //�ٴڰ� �ε�������, �������
        //= : <= ����
        //==: ��. �̰� �´�?
        if(collision.name == "floor")
        {
            //sGM.playerLife -= 1;
            sGM.playerLife--;
            sGM.ShowHeart();
            animator.SetTrigger("a");
        }
        if(collision.name == "player")
        {
            Debug.Log("�÷��̾��ı�");
            //[������Ʈ�� ���ִ� ���]
            //1. ������ ���ֱ� : Destroy(������ ������Ʈ);
            //Destroy(collision.gameObject);
            //[v]2. ��������ó�� ���̱� : ���ӿ�����Ʈ.SetActive(fasle);
            collision.gameObject.SetActive(false);
            animator.SetTrigger("a");
        }
    } 


}
