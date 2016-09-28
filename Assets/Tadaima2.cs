using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Tadaima2 : MonoBehaviour {
	public GameObject Tadaima02;
	float myTimer = 0.0f;
	bool hantei = false;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		myTimer += Time.deltaTime;
		if(myTimer >=3 && hantei == false){
			Instantiate(Tadaima02, new Vector3(38, 10.6f, 35.7f), Quaternion.Euler (0, 180, 0));
			hantei = true;
		}	
	}
}
