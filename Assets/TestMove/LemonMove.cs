using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LemonMove : MonoBehaviour
{
    public Rigidbody2D lemonRB;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //코드실행순서

        float hori = Input.GetAxis("Horizontal");
        float verti = Input.GetAxis("Vertical");

        lemonRB.velocity = new Vector2(hori, verti);
    }
}
