using UnityEngine;
using System.Collections;

public class PlayerSelectController : MonoBehaviour {

	public int MinLane;
	public int MaxLane;

	static int targetLane = 2;
	public GameObject Selecter1;
	public GameObject Selecter2;
	public GameObject Selecter3;
	public GameObject States1;
	public GameObject States2;
	public GameObject States3;
	public GameObject GameStart;


	void Start () {
		GameStart.SetActive (false);
	}

	void Update () {
		
		if (Input.GetKeyDown ("left"))
			MoveToLeft ();
		
		if (Input.GetKeyDown ("right"))
			MoveToRight ();
		
		if (Input.GetButtonDown ("Jump")) {
			GameStart.SetActive (true);

			if (Input.GetButtonDown ("Jump")) {
				Selectnumber ();
				Application.LoadLevel ("Main");

			}
		}
		


		if (targetLane == 2) {
			Selecter2.SetActive (true);
			Selecter1.SetActive (false);
			Selecter3.SetActive (false);
			States2.SetActive (true);
		}

		if (targetLane == 1) {
			Selecter3.SetActive (false);
			Selecter2.SetActive (false);
			Selecter1.SetActive (true);
			States3.SetActive (true);
		}

		if (targetLane == 3) {
			Selecter1.SetActive (false);
			Selecter2.SetActive (false);
			Selecter3.SetActive (true);
			States1.SetActive (true);
		}
	
	}

	public static int Selectnumber(){
		return targetLane;
	}

	public void MoveToLeft(){
		if (targetLane > MinLane)
			targetLane--;
	}

	public void MoveToRight(){
		if (targetLane < MaxLane)
			targetLane++;
	}
}
