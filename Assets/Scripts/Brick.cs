using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
    public static int breakableCount = 0;
    public AudioClip crackSound;
    private int maxHits;
    public Sprite[] hitSprites;
    public int timesHit;
    private LevelManager LevelManagerInstance;
    bool isBreakable = false;

    // Use this for initialization
    void Start () {
        isBreakable = (this.tag == "breakable");
        if (isBreakable)
        {
            breakableCount++;
        }
        timesHit = 0;
        LevelManagerInstance = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    void SimulateWin()
    {
        LevelManagerInstance.LoadNextLevel();
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (isBreakable)
        {
            handleHits();
            print("Zostalo " + breakableCount + " breakablke klockoof");
        }

    }

    void handleHits()
    {
        timesHit++;
        maxHits = hitSprites.Length + 1;
        if (timesHit == maxHits) { AudioSource.PlayClipAtPoint(crackSound, transform.position); Destroy(gameObject); breakableCount--;  }
        else { LoadSprites(); }
        print("collisionWithBrickMothofoka");
        if (breakableCount == 0) { SimulateWin(); }
    }
    void LoadSprites()
    {
        int spriteIndex = timesHit - 1;
        this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
    }
    
    
}
