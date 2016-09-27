using UnityEngine;
using System.Collections;

public class Unity_Voice_Jump : MonoBehaviour {
	
	public AudioSource sound01;
	float myTimer = 0.0f;
	bool hantei = false;
	
	void Start () {
		
	}
	
	void Update () {
		myTimer += Time.deltaTime;
		if(myTimer > 8.5) {
			if(hantei == false){
				sound01.PlayOneShot(sound01.clip);
				hantei = true;
			}
		}
	}
}