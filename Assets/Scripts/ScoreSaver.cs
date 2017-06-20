using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSaver : MonoBehaviour {

	public int score;

	// Use this for initialization
	void Start () {
		ScoreKeeper scoreKeeper = FindObjectOfType<ScoreKeeper> ();
		if (scoreKeeper) {
			score = scoreKeeper.score;
			Destroy (scoreKeeper.gameObject);
		}

	}

}
