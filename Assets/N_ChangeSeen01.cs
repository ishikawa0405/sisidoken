using UnityEngine;
using System.Collections;

public class N_ChangeSeen01 : MonoBehaviour {
	
	float myTimer = 0.0f;
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		myTimer += Time.deltaTime;
		Debug.Log (myTimer);
		if(myTimer >=32){{
				Application.LoadLevel("SeenChangPuroto");
				
			}
		}
	}
}

