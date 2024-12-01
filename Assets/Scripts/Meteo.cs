using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteo : MonoBehaviour
{
    public Rigidbody2D meteoRB;
    public float speed = 6f;

    // Start is called before the first frame update
    void Start()
    {
        meteoRB.velocity = new Vector2(0,-speed);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
