using UnityEngine;
using System.Collections;


public class MainCameraController: MonoBehaviour {

	public float speedx;
	public int MinHorizontalLane = -2;
	public int MaxHorizontalLane = 2;


	public float LaneWidth = 15.0f;

	CharacterController controller;

	int targetHorizontalLane;

	Vector3 moveDirection = Vector3.zero;

	void Start () {
		controller = GetComponent<CharacterController> ();
	}

	void Update () {
		if (Input.GetKeyDown ("left"))
			MoveToLeft ();
		if (Input.GetKeyDown ("right"))
			MoveToRight ();

		float ratioX = (targetHorizontalLane * LaneWidth - transform.position.x) / LaneWidth;
		moveDirection.x = ratioX * speedx;


		Vector3 globalDirection = transform.TransformDirection (moveDirection);
		controller.Move (globalDirection * Time.deltaTime);
	

	}

	public void MoveToLeft(){
		if (targetHorizontalLane > MinHorizontalLane)
			targetHorizontalLane--;
	}

	public void MoveToRight(){
		if (targetHorizontalLane < MaxHorizontalLane)
			targetHorizontalLane++;
	}
		
}
