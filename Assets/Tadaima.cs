using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Tadaima : MonoBehaviour {
	public GameObject Tadaima01;
	float myTimer = 0.0f;
	bool hantei = false;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		myTimer += Time.deltaTime;
		if(myTimer >=0.2 && hantei == false){
			Instantiate(Tadaima01, new Vector3(38f, 11.5f, 35.7f), Quaternion.Euler (0, 180, 0));
			hantei = true;
		}	
	}
}
