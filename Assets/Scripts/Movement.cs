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
        Input.GetAxis("Horizontal"); //�¿����Ű, a,dŰ�� ��������
                                     //-1(����) ~ 1(������) ���� ����

        float verti =
        Input.GetAxis("Vertical"); //���Ϲ���Ű, w,sŰ�� ��������
                                   //-1(�Ʒ���) ~ 1(����) ���� ����

        playerRB.velocity = new Vector2() * speed;

        //[����]
        //���ʹ���Ű�� ����. hori = -1
        //playerRB.velocity = new Vector2(-1, 0)
        //�������� �̵�

        //�����ʹ���Ű�� ����. hori = +1
        //playerRB.velocity = new Vector2(+1, 0)
        //���������� �̵�
    }
}
