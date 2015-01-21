using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float TurnSpeed = 0.08f;
	public float MoveSpeed = 0.5f;
	public float JumpSpeed = 5.0f;
	
	float turnAmount;
	float moveAmount;

	bool jump;

	void Start () {
		print (transform.forward);
	}

	void FixedUpdate() {
		Vector3 facing = transform.forward.normalized;
		Vector3 left = Vector3.Cross(facing, Vector3.up);

		transform.position = transform.position + facing * MoveSpeed * moveAmount;
		transform.forward = (left * turnAmount * TurnSpeed + facing).normalized;

		if(jump)
		{
			rigidbody.AddForce(Vector3.up * JumpSpeed);
		}
	}

	void Update () {
		turnAmount = Input.GetAxis("Horizontal");
		moveAmount = Input.GetAxis("Vertical");

		jump = Input.GetButtonDown("Jump");
	}
}
