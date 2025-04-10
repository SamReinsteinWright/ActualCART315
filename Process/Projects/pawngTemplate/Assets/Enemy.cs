using System;
using System.Collections;
using UnityEditor.Tilemaps;
using UnityEngine;
using Random = UnityEngine.Random;

public class Enemy : MonoBehaviour
{
    public float yPos, xPos;
    private Rigidbody2D rb;
    [SerializeField] private float rotationspeed;
    private float mouseX, mouseY;
    private Vector2 position;
    Vector3 lastMousePos;
    public Transform target;
    public float speed = 0.001f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }



    private void OnTriggerStay2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Sheep"))
        {
            Debug.Log(other.gameObject.transform.position);
            var otherPos = other.gameObject.transform.position;
            Vector2 newPos = Vector2.MoveTowards(
                rb.position,
                otherPos,
                speed * Time.fixedDeltaTime
            );
            rb.MovePosition(newPos);

        }

        // Update is called once per frame
        void Update()
        {
        }



    }
}
