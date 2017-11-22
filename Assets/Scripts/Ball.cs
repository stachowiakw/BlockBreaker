using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    private Paddle PaddleInstance;
    private bool HasStarted = false;
    private Vector3 paddleToBallVector;
    private float randomStartDirection = 0;

    // Use this for initialization
    void Start () {
        PaddleInstance = GameObject.FindObjectOfType<Paddle>();
        paddleToBallVector = this.transform.position - PaddleInstance.transform.position;
        print(paddleToBallVector);
        if (Random.value < 0.5f) { randomStartDirection = -2f; } else { randomStartDirection = 2f; }
	}
	
	// Update is called once per frame
	void Update () {
        if (HasStarted == false) { this.transform.position = PaddleInstance.transform.position + paddleToBallVector; }

        if(Input.GetMouseButtonDown(0))
        {
            print("MouseClicked, lunching ball");
            if (HasStarted == false) { GetComponent<Rigidbody2D>().velocity = new Vector2(randomStartDirection, 10f); }
            HasStarted = true;
        }
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 randomBounce = new Vector2(Random.Range(0f, 0.7f), Random.Range(0f, 0.7f));
        GetComponent<Rigidbody2D>().velocity += randomBounce;
        if (HasStarted == true) { GetComponent<AudioSource>().Play(); }
    }
}
