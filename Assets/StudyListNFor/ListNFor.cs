using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ListNFor : MonoBehaviour
{
    //listȰ���ϴ¹�
    //(1) �ƹ��͵� ���°��� ������, �ν�����â���� �� �Ҵ�
    //(2) ���� �����Ҷ�, �� �Ҵ�.
    public List<int> nums = new List<int> { 10,20,30,40,50};
    public List<string> word = new List<string> { "��", "��", "��"};

    public List<int> countA;
    public List<int> countB;

    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < 5; i++)
        {
            countA[i] = 5 * i;
        }

        for (int i = 0; i < countB.Count; i++)
        {
            countB[i] = 5 * i + 5;
        }    




        Debug.Log(nums[1]);
        Debug.Log(word[0]);

        //�ۼ��� ���ڸ�ŭ �ڵ尡 �ݺ�.
        for (int i = 0; i < nums.Count; i++)
        {
            nums[i] = 10 * i;
            //nums[0] = 100 * 0;
            //nums[1] = 100 * 1;
            //nums[2] = 100 * 2;
            //Debug.Log("����" + i);
        }

        //int i = 0; 0 < 3; �ڵ�O i++; -> i = 1;
        //int i = 1; 1 < 3; �ڵ�O i++; -> i = 2;
        //int i = 2; 2 < 3; �ڵ�O i++; -> i = 3;
        //int i = 3; 3 < 3; �ڵ�x
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
