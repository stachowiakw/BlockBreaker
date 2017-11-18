using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LevelChange(string name)
	{
		Debug.Log("no elo " + name);
		Application.LoadLevel(name);
	}
	
	public void RequestQuit()
	{
		Debug.Log("qqqqqquit!");
		Application.Quit();
	}
}
