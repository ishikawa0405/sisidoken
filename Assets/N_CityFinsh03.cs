using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class N_CityFinsh03 : MonoBehaviour {
	public GameObject CityFinish03;
	float myTimer = 0.0f;
	bool hantei = false;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		myTimer += Time.deltaTime;
		if(myTimer >=6 && hantei == false){
			Instantiate(CityFinish03, new Vector3(1027.5f, -40.9f, -22), Quaternion.Euler (0, 180, 0));
			hantei = true;
		}	
	}
} 
