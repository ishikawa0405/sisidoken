using UnityEngine;
using System.Collections;

public class N_ChangeSeen0f : MonoBehaviour {
	
	float myTimer = 0.0f;
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		myTimer += Time.deltaTime;
		if(myTimer >=12){{
				Application.LoadLevel("UK-Story");
				
			}
		}
	}
}
