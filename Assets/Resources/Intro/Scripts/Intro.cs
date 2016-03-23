using UnityEngine;
using System.Collections;

public class Intro : MonoBehaviour {

	public string levelToLoad;
	public void LoadLevel(){
		try {
			Application.LoadLevel(levelToLoad);
		} catch {
			Debug.Log("Invalid Level, please check if this level in built sistem");
		}
	}
}
