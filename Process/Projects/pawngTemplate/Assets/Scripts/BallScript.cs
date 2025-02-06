using System.Collections;
using UnityEngine;

public class BallScript : MonoBehaviour {
    public float ballSpeed = 2;

    private int [] directions = {-1,1};
    private int hDir, yDir;

    public int score1, score2;
    public AudioSource blip;
    
    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        StartCoroutine(Launch());
    }

    private void OnCollisionEnter2D(Collision2D wall)
    {
        if (wall.gameObject.name == "leftWall")
        {
            //give points to player 2
            score1++;
            //reset
            Reset();
        }
        if (wall.gameObject.name == "rightWall")
        {
            //give points to player 1
            score2++;
            //reset
            Reset();
        }

        if (wall.gameObject.name == "topWall" || wall.gameObject.name == "bottomWall")
        {
        
        }
        if (wall.gameObject.name == "paddleLeft" || wall.gameObject.name == "paddleRight")
        {
            var leftPosX = GameObject.Find("paddleLeft").transform.position.x;
            var rightPosX = GameObject.Find("paddleRight").transform.position.x;
            var leftPosY = GameObject.Find("paddleLeft").transform.position.y;
            var rightPosY = GameObject.Find("paddleRight").transform.position.y;
            var posX = GameObject.Find("Ball").transform.position.x;
            var posY = GameObject.Find("Ball").transform.position.y;
            rb.AddForce(transform.right * (posX - leftPosX) * ballSpeed);
            rb.AddForce(transform.right * (posX - rightPosX) * ballSpeed);
            rb.AddForce(transform.up * (posY - leftPosY) * ballSpeed);
            rb.AddForce(transform.up * (posY - rightPosY) * ballSpeed);
            
        }
    }
    // Update is called once per frame
    void Update()
    {
       
    }

    private IEnumerator Launch()
    {
        //choose random x and y dir
        hDir = directions[Random.Range(0, directions.Length)];
        yDir = directions[Random.Range(0, directions.Length)];
        // wait for X seconds
        yield return new WaitForSeconds(1);
        //apply force
        //  vert
        rb.AddForce(transform.right * hDir * ballSpeed);
        //  hor
        rb.AddForce(transform.up * yDir * ballSpeed);
    }

    void Reset()
    {
        //reset wait
        rb.linearVelocity = Vector2.zero;
        //reset to 0,0
        this.transform.localPosition = new Vector3(0, 0, 0);
        //launch
        StartCoroutine(Launch());
    }
}
