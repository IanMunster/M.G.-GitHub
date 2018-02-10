using UnityEngine;
using System.Collections;

public class RotatePickUp : MonoBehaviour {

	public Vector3 rotation;
	public float rotationSpeed;

	// Update is called once per frame
	void Update () {
		transform.Rotate(rotation * rotationSpeed * Time.deltaTime);

	}
}
