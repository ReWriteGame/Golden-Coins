using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(Collider2D))]
public class Knife : MonoBehaviour
{
    [SerializeField] private float force = 1;

    public float Force { get => force; private set => force = value; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Block>())
        {
            transform.parent = collision.transform;
            transform.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
    }
}
