﻿using UnityEngine;
using System.Collections;

public class K_Change_question1 : MonoBehaviour {
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
		if(myTimer >=3){{
				Application.LoadLevel("K_Jump");
				//DontDestroyOnLoad();
			}
		}
	}
}