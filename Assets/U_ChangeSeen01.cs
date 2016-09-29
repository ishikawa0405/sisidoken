using UnityEngine;
using System.Collections;

public class U_ChangeSeen01 : MonoBehaviour {

	float myTimer = 0.0f;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		myTimer += Time.deltaTime;
		if(myTimer >=6){{
				Application.LoadLevel("SeenChangPuroto");

			}
		}
	}
}
