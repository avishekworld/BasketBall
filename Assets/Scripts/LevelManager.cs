using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public double timeRemaining = 5.0;

	void Update () {
		if (timeRemaining > 0) {
			timeRemaining -= Time.deltaTime;
			if (timeRemaining < 0) {
				LoadNextScene ();
			}
		}
	}

	public void LoadNextScene(){
		int currentSceneIndex = SceneManager.GetActiveScene ().buildIndex;
		SceneManager.LoadScene (currentSceneIndex + 1);
	}

	public void LoadPreviousScene(){
		int currentSceneIndex = SceneManager.GetActiveScene ().buildIndex;
		SceneManager.LoadScene (currentSceneIndex - 1);
	}
}
