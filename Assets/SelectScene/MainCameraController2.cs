using UnityEngine;
using System.Collections;


public class MainCameraController2: MonoBehaviour {

	public float speedx;
	/*public int MinHorizontalLane = -2;
	public int MaxHorizontalLane = 2;
	*/

	public float LaneWidth = 15.0f;

	CharacterController controller;

	//int targetHorizontalLane2;

	Vector3 moveDirection = Vector3.zero;

	void Start () {
		controller = GetComponent<CharacterController> ();
	}

	void Update () {
		/*if (Input.GetKeyDown ("a"))
			MoveToLeft ();
		if (Input.GetKeyDown ("d"))
			MoveToRight ();
			*/

		int targetHorizontalLane2 = DoublePlayerSelectController.Selectnumber2 ();

		float ratioX = (targetHorizontalLane2 * LaneWidth - transform.position.x) / LaneWidth;
		moveDirection.x = ratioX * speedx;


		Vector3 globalDirection = transform.TransformDirection (moveDirection);
		controller.Move (globalDirection * Time.deltaTime);


	}

	/*public void MoveToLeft(){
		if (targetHorizontalLane2 > MinHorizontalLane)
			targetHorizontalLane2--;
	}

	public void MoveToRight(){
		if (targetHorizontalLane2 < MaxHorizontalLane)
			targetHorizontalLane2++;
	}
	*/
}
