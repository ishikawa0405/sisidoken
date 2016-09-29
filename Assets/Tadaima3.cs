using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Tadaima3 : MonoBehaviour {
	public GameObject Tadaima03;
	float myTimer = 0.0f;
	bool hantei = false;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		myTimer += Time.deltaTime;
		if(myTimer >=5 && hantei == false){
			Instantiate(Tadaima03, new Vector3(35.8f, 10.9f, 28.9f), Quaternion.Euler (0, -90, 0));
			hantei = true;
		}	
	}
}
