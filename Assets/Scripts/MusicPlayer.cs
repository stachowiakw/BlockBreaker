using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
static MusicPlayer Instances = null;
    void Awake()
    {
        Debug.Log("Music player Awake " + GetInstanceID());
        if (MusicPlayer.Instances != null)
        {
            Destroy(gameObject);
            print("Duplicate music player self-destruct during awaking");
        } else {	
			GameObject.DontDestroyOnLoad(gameObject);
			Instances = this;
		}
    }


    // Use this for initialization
    void Start()
    {

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
