﻿using UnityEngine;
using System.Collections;


public class Player1Controller : MonoBehaviour {


	public GameObject Banshi; 
	public GameObject Unicorn; 
	public GameObject Fenecs; 

int selectnumber1 = DoublePlayerSelectController.Selectnumber1 ();

void Update () {

	if (selectnumber1 == 2) {
		Banshi.SetActive (false);
		Unicorn.SetActive (true);
		Fenecs.SetActive (false);
	}

	if (selectnumber1 == 1) {
		Banshi.SetActive (true);
		Unicorn.SetActive (false);
		Fenecs.SetActive (false);
	}

	if (selectnumber1 == 3) {
		Banshi.SetActive (false);
		Unicorn.SetActive (false);
		Fenecs.SetActive (true);
	}

}
}
 

