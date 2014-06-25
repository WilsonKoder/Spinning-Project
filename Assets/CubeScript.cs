using UnityEngine;
using System.Collections;

public class CubeScript : MonoBehaviour {

	public float rotationSpeed = 25f;

	// Use this for initialization
	void Start () {
		rotationSpeed = 25f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);

	}
}
