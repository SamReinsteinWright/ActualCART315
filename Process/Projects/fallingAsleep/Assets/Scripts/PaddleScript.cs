using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    public float xLoc, yLoc, speed = 0.2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        xLoc = 0;
        yLoc = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("left");
            xLoc -= speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("right");
            xLoc += speed;
        }
        this.transform.position = new Vector3(xLoc, yLoc, 0);
    }
    
}
