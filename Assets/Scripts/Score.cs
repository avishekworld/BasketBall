using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {
	int score = 0 ;
	void OnCollisionEnter(Collision collison){
		score++;
		Debug.Log ("Score : " + score);
	}
}
