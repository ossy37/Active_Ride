﻿using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class TitleScene : MonoBehaviour {

	public Text blinkText;
<<<<<<< HEAD
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		//ボタンを押したら遷移
		if (Input.anyKeyDown) {
			Application.LoadLevel("Main");
=======
    public GameObject ModalWindow;
    private bool ModalDiagloFrag = true;


    // Use this for initialization
    void Start () {
        //ModalWindow.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
	
		//ボタンを押したら遷移
		if (Input.anyKeyDown) {

			Application.LoadLevel("SelectMenu");
>>>>>>> origin/motttey/ui-modify
		}
		
		//ボタンを押させるためのメッセージを点滅させる
		blinkText.color = new Color(1, 1, 1, Mathf.PingPong(Time.time, 1));
	}
}
