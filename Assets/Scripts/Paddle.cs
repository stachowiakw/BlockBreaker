using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool AutoPlay = false;
    private Ball ballInstance;
    // Use this for initialization
    void Start()
    {
        ballInstance = FindObjectOfType<Ball>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!AutoPlay) { MoveWithMouse(); } else { AutoPaddle(); }
    }

    void AutoPaddle()
    {
        Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, this.transform.position.z);

        Vector3 ballInstancePosition = ballInstance.transform.position;
        paddlePos.x = Mathf.Clamp(ballInstancePosition.x, 0.5f, 15.5f);

        this.transform.position = paddlePos;
    }

    void MoveWithMouse()
    {
        Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, this.transform.position.z);

        float PositionInBlocks = Input.mousePosition.x / Screen.width * 16;
        paddlePos.x = Mathf.Clamp(PositionInBlocks, 0.5f, 15.5f);

        this.transform.position = paddlePos;
    }
}