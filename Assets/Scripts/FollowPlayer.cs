using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

	public Transform PlayerTransform;
	public Vector3 Follow;

	void Start () {
	}

	void Update () {
		transform.position = PlayerTransform.position + Follow;
		transform.LookAt(PlayerTransform.position);
	}
}
