﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour {
	public int score = 0 ;

	public void incrementScore(int point){
		score += point;
	}
}
