using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour {

	public GameObject ballPrefab;
	Camera camera;
	public float force = 20.0f;

	void Start () {
		
	}

	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			GameObject ball = Instantiate (ballPrefab);
			ball.transform.position = transform.position;
			camera = GetComponentInChildren<Camera>();
			ball.GetComponent<Rigidbody> ().velocity =  camera.transform.rotation * Vector3.forward * force;
		}
	}
}
