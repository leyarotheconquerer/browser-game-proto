using UnityEngine;
using System.Collections;

public class RotatingAnimation : MonoBehaviour {

	public float RotateRate = 1.0f;

	void Start () {
	
	}

	void Update () {
		this.transform.Rotate(new Vector3(0.0f, 0.0f, RotateRate));
	}
}
