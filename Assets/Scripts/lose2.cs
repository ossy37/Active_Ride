using UnityEngine;
using System.Collections;

public class lose2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		//体力０で消滅
		if(PlayerAp2.armorPoint <= 0){
			gameObject.SetActive (false);
		}


	}
}
