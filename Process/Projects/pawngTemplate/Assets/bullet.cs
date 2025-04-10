using System;
using UnityEngine;

public class bullet : MonoBehaviour
{
    [Range(1,10)]
    [SerializeField]
    private float speed = 10f;
    
    [Range(1,10)]
    [SerializeField] private float lifeTime = 10;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, lifeTime);
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = transform.up * speed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Sheep"))
        {
            //Destroy(gameObject);
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
