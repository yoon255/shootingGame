using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Square : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log($"CollisionEnter2D: {collision.gameObject.name}");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"TriggerEnter2D: {collision.name}");
    }

}
