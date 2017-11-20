using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour {

    private LevelManager LevelManagerInstance;

    //void OnTriggerEnter2D(Collider2D trigger)
    //{
    //    LevelManagerInstance = GameObject.FindObjectOfType<LevelManager>();
    //    print("Trigger");
    //    LevelManagerInstance.LevelChange("Lose");
    // }

    void OnCollisionEnter2D(Collision2D collision)
    {
        LevelManagerInstance = GameObject.FindObjectOfType<LevelManager>();
        print("Collision");
        Brick.breakableCount = 0;
        LevelManagerInstance.LevelChange("Lose");
    }
}
