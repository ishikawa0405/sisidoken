using UnityEngine;
using System.Collections;

public class K_Unity_voice : MonoBehaviour {
	
	public AudioSource sound01;
	//public AudioSource sound02;
	float myTimer = 0.0f;
	bool hantei = false;
	//bool hantei2 = false;
	
	void Start () {
		
	}
	
	void Update () {
		myTimer += Time.deltaTime;
		if(myTimer > 9) {
			if(hantei == false){
				sound01.PlayOneShot(sound01.clip);
				hantei = true;
			}
		}

	}
}