using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryGoalTrigger : MonoBehaviour {

	Collider expectedCollider;

	public void ExpectCollider(Collider collider){
		expectedCollider = collider;
	}

	void OnTriggerEnter(Collider collider){
		if (collider == expectedCollider) {
			ScoreKeeper scoreKeeper = FindObjectOfType<ScoreKeeper>();
			scoreKeeper.incrementScore (1);
		}
	}
}
