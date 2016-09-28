using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GoodNight : MonoBehaviour {
	public GameObject GoodNight_bed;
	float myTimer = 0.0f;
	bool hantei = false;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		myTimer += Time.deltaTime;
		if(myTimer >=7.5 && hantei == false){
			Instantiate(GoodNight_bed, new Vector3(274.8f, 29.8f, 77.7f), Quaternion.Euler (0, -90, 0));
			hantei = true;
		}	
	}
}
