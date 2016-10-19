using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

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
    public GameObject Character1;
    public GameObject Character2;
    public GameObject Character3;

    public GameObject Character1Active;
    public GameObject Character2Active;
    public GameObject Character3Active;

    public Text Character1Text;
    public Text Character2Text;
    public Text Character3Text;


    public Sprite BANS1;
    public Sprite BANS2;

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
            Character2Active.SetActive(true);
            Character1Active.SetActive(false);
            Character3Active.SetActive(false);

            //Character1image = GameObject.Find("BANS2").GetComponent<Image>();
            //Character1image.sprite = BANS1;
            Debug.Log(Character1Text.GetComponent<Text>().text);
            Debug.Log(Character2Text.GetComponent<Text>().text);
            Debug.Log(Character3Text.GetComponent<Text>().text);

            //Character1Text.GetComponent<Text>().color = Color.white;
            //Character2Text.GetComponent<Text>().color = Color.white;
            //Character2Text.GetComponent<Text>().color = new Color(1, 0, 1);

        }

        if (targetLane == 1) {
			Selecter3.SetActive (false);
			Selecter2.SetActive (false);
			Selecter1.SetActive (true);
            Character3Active.SetActive(false);
            Character2Active.SetActive(false);
            Character1Active.SetActive(true);
            States3.SetActive (true);

            //Character1Text.GetComponent<Text>().color = new Color(1, 0, 1);
            //Character2Text.GetComponent<Text>().color = new Color(1, 1, 1);
            //Character3Text.GetComponent<Text>().color = new Color(1, 1, 1);
        }

        if (targetLane == 3) {
			Selecter1.SetActive (false);
			Selecter2.SetActive (false);
			Selecter3.SetActive (true);
            Character1Active.SetActive(false);
            Character2Active.SetActive(false);
            Character3Active.SetActive(true);
            States1.SetActive (true);

            //Character1Text.GetComponent<Text>().color = Color.white;
            //Character2Text.GetComponent<Text>().color = new Color(1, 1, 0);
            //Character3Text.GetComponent<Text>().color = Color.white;

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
