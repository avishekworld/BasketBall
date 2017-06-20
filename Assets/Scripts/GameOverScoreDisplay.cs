﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScoreDisplay : MonoBehaviour {


	ScoreSaver scoreSaver;
	Text text;
	// Use this for initialization
	void Start () {
		scoreSaver = FindObjectOfType<ScoreSaver> ();
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Score:" + scoreSaver.score;
	}
}
