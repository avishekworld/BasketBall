using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBouncer : MonoBehaviour {

	void OnCollisionEnter(Collision collison){
		AudioSource audioSource = GetComponent<AudioSource> ();
		audioSource.Play ();
	}
}
