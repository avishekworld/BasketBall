using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetector : MonoBehaviour {

	ScoreKeeper scoreKeeper;
	public int hitPoint = 1;

	void Start () {
		scoreKeeper = FindObjectOfType<ScoreKeeper>();
	}
	
	void OnCollisionEnter(Collision collison){
		scoreKeeper.incrementScore (hitPoint);
	}
}
