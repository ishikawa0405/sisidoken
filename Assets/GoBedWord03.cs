using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GoBedWord03 : MonoBehaviour {
	public GameObject GoBedWord;
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
		if(myTimer >=10 &&  myTimer< 20 && hantei == false){
			prehub = (GameObject)Instantiate(GoBedWord, new Vector3(185f, 34f, 93f), Quaternion.Euler (0, -90, 0));
			hantei = true;

		}	
		if(myTimer >=20 && hantei == true){
			Destroy(prehub);			
		}	
	}
}
