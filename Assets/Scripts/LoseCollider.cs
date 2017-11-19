using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour {

    public LevelManager LevelManagerInstance;

    void OnTriggerEnter2D(Collider2D trigger)
    {
        print("Trigger");
        LevelManagerInstance.LevelChange("Win");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision");
        LevelManagerInstance.LevelChange("Win");
    }
}
