using UnityEngine;
using System.Collections;

public class Taich_Voice : MonoBehaviour {
	
	public AudioSource sound01;
	public AudioSource sound02;
	float myTimer = 0.0f;
	bool hantei = false;
	bool hantei2 = false;
	
	void Start () {
		
	}
	
	void Update () {
		myTimer += Time.deltaTime;
		/*if(myTimer > 1.0) {
			if(hantei == false){
				sound01.PlayOneShot(sound01.clip);
				hantei = true;
			}
		}*/
		if (myTimer > 4.0) {
			if(hantei2 == false){
				sound02.PlayOneShot(sound02.clip);
				hantei2 = true;
			}
		}
	}
}