using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour
{
    public int playerLife = 3;
    public List<Image> heartImgs;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowHeart()
    {
        //�����ŭ ��Ʈ�� ���󺯰�
        for (int i = 0; i < 3; i++)
        {
            if (i <= playerLife - 1)
            {
                heartImgs[i].color = Color.white;
            }
            else
            {
                heartImgs[i].color = new Color(0.3f, 0.3f, 0.6f);
            }
        }
    }


}
