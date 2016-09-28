using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GoBedWord01 : MonoBehaviour {
	public GameObject GoBedWord;
	float myTimer = 0.0f;
	bool hantei = false;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		myTimer += Time.deltaTime;
		if(myTimer >=1.5 && hantei == false){
			Instantiate(GoBedWord, new Vector3(201.7f, 35.3f, 79.7f), Quaternion.Euler (0, -90, 0));
			hantei = true;
		}	
	}
}
