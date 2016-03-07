using UnityEngine;
using System.Collections;

public class Unity_Omedetou_Voice : MonoBehaviour {
	
	public AudioSource sound01;
	float myTimer = 0.0f;
	bool hantei = false;
	
	void Start () {
		
	}
	
	void Update () {
		myTimer += Time.deltaTime;
		if(myTimer > 4.0) {
			if(hantei == false){
				sound01.PlayOneShot(sound01.clip);
				hantei = true;
			}
		}
	}
}