using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour {
	public int score = 0 ;

	void Start(){
		DontDestroyOnLoad (gameObject);
	}

	public void incrementScore(int point){
		score += point;
	}
}
