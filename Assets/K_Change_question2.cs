using UnityEngine;
using System.Collections;

public class K_Change_question2 : MonoBehaviour {
	//private static bool created = false;
	float myTimer = 0.0f;
	// Use this for initialization
	/*void Awake() {
		DontDestroyOnLoad(transform.gameObject);
	}*/
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		myTimer += Time.deltaTime;
		if(myTimer >=6){{
				Application.LoadLevel("K_Rise_left");
				//DontDestroyOnLoad();
			}
		}
	}
}
