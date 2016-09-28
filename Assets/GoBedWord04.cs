using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GoBedWord04 : MonoBehaviour {
	public GameObject BathroomWord;
	float myTimer = 0.0f;
	bool hantei = false;
	GameObject prehub;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		myTimer += Time.deltaTime;
		if(myTimer >=22 && hantei == false){
			prehub = (GameObject)Instantiate(BathroomWord, new Vector3(174f, 34f, 88f), Quaternion.Euler(0, 90f, 0));
			hantei = true;
		}	
	}
}