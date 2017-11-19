using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LevelChange(string name)
	{
		Debug.Log("no elo " + name);
		SceneManager.LoadScene(name);
   
	}
	
	public void RequestQuit()
	{
		Debug.Log("qqqqqquit!");
		Application.Quit();
	}
}
