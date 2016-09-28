using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NewBehaviourScript3 : MonoBehaviour {
	public GameObject BathroomWord;
	float myTimer = 0.0f;
	bool hantei = false;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		myTimer += Time.deltaTime;
		if(myTimer >=0.5 && hantei == false){
			Instantiate(BathroomWord, new Vector3(63.2f, 10f, 77f), Quaternion.Euler (0, -90, 0));
			hantei = true;
		}
			
	}
}
