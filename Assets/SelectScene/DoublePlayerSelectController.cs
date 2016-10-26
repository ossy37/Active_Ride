using UnityEngine;
using System.Collections;

public class DoublePlayerSelectController : MonoBehaviour {

	public int MinLane;
	public int MaxLane;

	static int onetargetLane = 2;
	public GameObject Selecter11;
	public GameObject Selecter12;
	public GameObject Selecter13;
	public GameObject States11;
	public GameObject States12;
	public GameObject States13;
	static int twotargetLane = 3;
	public GameObject Selecter21;
	public GameObject Selecter22;
	public GameObject Selecter23;
	public GameObject States21;
	public GameObject States22;
	public GameObject States23;
	public GameObject GameStart;


	void Start () {
		GameStart.SetActive (false);
	}

	void Update () {

		if (Input.GetKeyDown ("left"))
			MoveToLeft1 ();

		if (Input.GetKeyDown ("right"))
			MoveToRight1 ();

		if (Input.GetKeyDown ("a"))
			MoveToLeft2 ();

		if (Input.GetKeyDown ("d"))
			MoveToRight2 ();


		if (Input.GetButtonDown ("Jump")) {
			GameStart.SetActive (true);

			if (Input.GetButtonDown ("Jump")) {
				Selectnumber1 ();
				Selectnumber2 ();
				Application.LoadLevel ("2PlayerMode");

			}
		}



		if (onetargetLane == 2) {
			Selecter12.SetActive (true);
			Selecter11.SetActive (false);
			Selecter13.SetActive (false);
			//States12.SetActive (true);
			Selectnumber1 ();
		}

		if (onetargetLane == 1) {
			Selecter13.SetActive (false);
			Selecter12.SetActive (false);
			Selecter11.SetActive (true);
			//States13.SetActive (true);
			Selectnumber1 ();
		}

		if (onetargetLane == 3) {
			Selecter11.SetActive (false);
			Selecter12.SetActive (false);
			Selecter13.SetActive (true);
			//States11.SetActive (true);
			Selectnumber1 ();
		}


		if (twotargetLane == 2) {
			Selecter22.SetActive (true);
			Selecter21.SetActive (false);
			Selecter23.SetActive (false);
			//States22.SetActive (true);
			Selectnumber2 ();
		}

		if (twotargetLane == 1) {
			Selecter23.SetActive (false);
			Selecter22.SetActive (false);
			Selecter21.SetActive (true);
			//States23.SetActive (true);
			Selectnumber2 ();
		}

		if (twotargetLane == 3) {
			Selecter21.SetActive (false);
			Selecter22.SetActive (false);
			Selecter23.SetActive (true);
			//States21.SetActive (true);
			Selectnumber2 ();
		}
	}

	public static int Selectnumber1(){
		return onetargetLane;
	}

	public static int Selectnumber2(){
		return twotargetLane;
	}

	public void MoveToLeft1(){
		if (onetargetLane - 1 == twotargetLane) {
			if (onetargetLane - 2 >= MinLane) {
				onetargetLane = onetargetLane - 2;
			}
		}else if (onetargetLane > MinLane)
			onetargetLane--;
	}

	public void MoveToRight1(){
		if (onetargetLane + 1 == twotargetLane) {
			if (onetargetLane + 2 <= MaxLane) {
				onetargetLane = onetargetLane + 2;
			}
		}else if (onetargetLane < MaxLane)
			onetargetLane++;
	}

	public void MoveToLeft2(){
		if (twotargetLane - 1 == onetargetLane) {
			if (twotargetLane - 2 >= MinLane) {
				twotargetLane = twotargetLane - 2;
			}
		}else if (twotargetLane > MinLane)
			twotargetLane--;
	}

	public void MoveToRight2(){
		if (twotargetLane + 1 == onetargetLane) {
			if (twotargetLane + 2 <= MaxLane) {
				twotargetLane = twotargetLane + 2;
			}
		}else if (twotargetLane < MaxLane)
			twotargetLane++;
	}
}
