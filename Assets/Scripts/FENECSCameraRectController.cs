﻿using UnityEngine;
using System.Collections;

public class FENECSCameraRectController : MonoBehaviour {

	int  playernumber1 = DoublePlayerSelectController.Selectnumber1 ();
	int  playernumber2 = DoublePlayerSelectController.Selectnumber2 ();


	public Camera camera;

	void Start () {

		if(playernumber1 == 3){

			camera.rect = new Rect (0, 0, 0.5F, 1);

		}

		if(playernumber2 == 3){

			camera.rect = new Rect (0.5F, 0, 0.5F, 1);

		}

	}

}