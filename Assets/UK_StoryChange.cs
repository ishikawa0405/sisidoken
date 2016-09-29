using UnityEngine;
using System.Collections;

public class UK_StoryChange : MonoBehaviour {
	
	float myTimer = 0.0f;
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		myTimer += Time.deltaTime;
		if(myTimer >=76){{
				Application.LoadLevel("U-room");
				
			}
		}
	}
}

