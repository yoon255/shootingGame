using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cha1 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log($"ºÎµúÈù³à¼®: {collision.gameObject.name}");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("ÀÛµ¿µÇ³ª?");
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
