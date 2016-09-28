using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GoBedWord02 : MonoBehaviour {
	public GameObject GoBedWord;
	float myTimer = 0.0f;
	bool hantei = false;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		myTimer += Time.deltaTime;
		if(myTimer >=4 && hantei == false){
			Instantiate(GoBedWord, new Vector3(201.7f, 34.3f, 79.7f), Quaternion.Euler (0, -90, 0));
			hantei = true;
		}	
	}
}
