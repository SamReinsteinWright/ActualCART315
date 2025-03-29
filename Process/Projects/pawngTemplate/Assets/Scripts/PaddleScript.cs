using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour {
    private Rigidbody2D rb;
    private float mx;
    private float my;
    [SerializeField] private GameObject BulletPrefab;
    [SerializeField] private Transform FiringPoint;
    [Range(0.1f,3f)]
    [SerializeField] private float FireRate = 0.5f;
    private Vector2 mousePos;
    
    private float fireTimer;
    
    private float     yPos, xPos;
    public float      paddleSpeed = 1f;
   
    public KeyCode upKey, downKey, leftKey, rightKey, spaceKey;
   
    // Start is called before the first frame update
    void Start() {
        transform.localPosition = new Vector3(xPos, yPos, 0);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        
        mx = Input.GetAxisRaw("Horizontal");
        my = Input.GetAxisRaw("Vertical");
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        float angle = Mathf.Atan2(mousePos.y - transform.position.y, mousePos.x - transform.position.x) * Mathf.Rad2Deg - 180f;
        
        transform.localRotation = Quaternion.Euler(0f, 0f, angle);

        if (Input.GetKey(spaceKey) && fireTimer < 0f)
        {
            Shoot();
            fireTimer = FireRate;
        }
        else
        {
            fireTimer -= Time.deltaTime;
        }
        
        if (Input.GetKey(downKey)) {
            yPos -= paddleSpeed;
        }

        if (Input.GetKey(upKey)) {
                yPos += paddleSpeed;
        }
        if (Input.GetKey(rightKey)) {
            xPos += paddleSpeed;
        }

        if (Input.GetKey(leftKey)) {
            xPos -= paddleSpeed;
        }
        transform.localPosition = new Vector3(xPos, yPos, 0);
    }

    private void Shoot()
    {
        Instantiate(BulletPrefab, FiringPoint.position, FiringPoint.rotation);
    }
}

