using UnityEngine;
using System.Collections;

public class OnePButtonClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void OnClick(){
        Debug.Log("Clicked.");
        Application.LoadLevel("Main");
    }
}
