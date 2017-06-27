using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimaryGoalTrigger : MonoBehaviour {

	void OnTriggerEnter(Collider collider){
		SecondaryGoalTrigger secondaryGoalTrigger = GetComponentInChildren<SecondaryGoalTrigger> ();
		secondaryGoalTrigger.ExpectCollider (collider);
	}
}
