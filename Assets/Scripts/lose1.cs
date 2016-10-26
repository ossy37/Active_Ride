using UnityEngine;
using System.Collections;


public class lose1 : MonoBehaviour {

	public GameObject explosion;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		//体力０で消滅
		if(PlayerAp1.armorPoint <= 0){
			gameObject.SetActive (false);
			//爆発エフェクトを表示する
			Instantiate(explosion, transform.position, transform.rotation);
		}
			
	}
}
