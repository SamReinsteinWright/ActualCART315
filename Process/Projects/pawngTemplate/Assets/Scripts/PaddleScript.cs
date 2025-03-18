using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour {
    private float     yPos, xPos;
    public float      paddleSpeed = .05f;
    public float StartingPosition;
    public KeyCode upKey, downKey, leftKey, rightKey;
    public float topWall, bottomWall, leftWall, rightWall;
    // Start is called before the first frame update
    void Start() {
        transform.localPosition = new Vector3(StartingPosition + xPos, yPos, 0);
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(downKey) && yPos > bottomWall) {
            yPos -= paddleSpeed;
        }

        if (Input.GetKey(upKey) && yPos < topWall) {
                yPos += paddleSpeed;
        }
        if (Input.GetKey(rightKey) && xPos < rightWall) {
            xPos += paddleSpeed;
        }

        if (Input.GetKey(leftKey) && xPos > leftWall) {
            xPos -= paddleSpeed;
        }
        transform.localPosition = new Vector3(StartingPosition+xPos, yPos, 0);
        
    }
}

