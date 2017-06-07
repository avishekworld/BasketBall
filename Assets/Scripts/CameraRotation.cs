using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour {
	Camera camera;
	void Start () {
		camera = GetComponentInChildren<Camera> ();
	}

	void Update () {
		float mouseX = Input.GetAxis ("Mouse X");
		float mouseY = Input.GetAxis ("Mouse Y");
		transform.rotation = Quaternion.Euler (0, mouseX, 0) * transform.rotation;
		camera.transform.localRotation = Quaternion.Euler (-mouseY, 0, 0) * camera.transform.localRotation;
	}
}
