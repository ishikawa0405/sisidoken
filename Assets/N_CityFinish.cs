﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class N_CityFinish : MonoBehaviour {
	public GameObject CityFinish;
	GameObject prehub;
	float myTimer = 0.0f;
	bool hantei = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		myTimer += Time.deltaTime;
		Debug.Log (myTimer);
		if(myTimer >=0.2 && myTimer < 2.5 && hantei == false){
			prehub = (GameObject)Instantiate(CityFinish, new Vector3(1027.5f, -40.9f, -22), Quaternion.Euler (0, 180, 0));
			hantei = true;
		}	
		if(myTimer >=2.5 && hantei == true){
			Destroy(prehub);			
		}	
	}
}
