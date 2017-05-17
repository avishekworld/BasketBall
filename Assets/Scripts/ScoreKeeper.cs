using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour {
	int score = 0 ;

	public void incrementScore(int point){
		score += point;
		Debug.Log ("Score : " + score);
	}
}
