using UnityEngine;
using System.Collections;

public class PlayerShoot1 : MonoBehaviour {

	public GameObject shot;
	public GameObject muzzle;
	public GameObject muzzle1;
	public GameObject muzzle2;
	public GameObject muzzle3;
	public GameObject muzzle4;
	public GameObject muzzleFlash;
	
	float shotInterval = 0;
	float shotIntervalMax = 0.5F;
	
	AudioSource audioSource;
	
	// Use this for initialization
	void Start () {
	
		audioSource = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
		//発射間隔を設定する
		shotInterval += Time.deltaTime;
	
		if(shotInterval > shotIntervalMax){
			
			//弾を発射する
			if( Input.GetButton("Fire1") ){
				Instantiate(shot, muzzle.transform.position, Camera.main.transform.rotation);
				Instantiate(shot, muzzle1.transform.position, Camera.main.transform.rotation);
				Instantiate(shot, muzzle2.transform.position, Camera.main.transform.rotation);
				Instantiate(shot, muzzle3.transform.position, Camera.main.transform.rotation);
				Instantiate(shot, muzzle4.transform.position, Camera.main.transform.rotation);
				shotInterval = 0;
				
				//マズルフラッシュを表示する
				Instantiate(muzzleFlash, muzzle.transform.position, transform.rotation);
				
				//SEを再生する
				//audioSource.Play();
				
				//音を重ねて再生する
				audioSource.PlayOneShot(audioSource.clip);
			}
			
		}
	}
}
