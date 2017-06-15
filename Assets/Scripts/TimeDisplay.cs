using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour {

	LevelManager levelManager;
	Text text;
	void Start () {
		levelManager = FindObjectOfType<LevelManager> ();
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Time Remaining:" + levelManager.timeRemaining;
	}
}
