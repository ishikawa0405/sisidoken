using UnityEngine;
using System.Collections;

public class wash_hands : MonoBehaviour {
	float M_Timer = 0.0f;
	bool hantei = false;
	bool hantei2 = false;
	bool hantei3 = false;
	bool hantei4 = false;
	bool hantei5 = false;
	public GameObject refObj;
	public GameObject S_wash;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		M_Timer += Time.deltaTime;
		Debug.Log (hantei3);
		Debug.Log (hantei5);
		if (M_Timer >= 6.0f) {
			if (hantei3 == true || hantei5 == true) {
				if(hantei4 == false){
					Instantiate (S_wash, new Vector3 (25.89f, 10.95f, 14.92f), Quaternion.Euler (0, 90f, 0));
				S_Open Seikai = refObj.GetComponent<S_Open> ();
				Seikai.Sound ();
				hantei4 = true;
				}
			}
		}
	}
	public void OnTriggerStay(Collider col){
		if (M_Timer >= 6.0f) {
			if (col.gameObject.tag == "lefthand") {
				hantei = true;
			} 
			if (col.gameObject.tag == "righthand") {
				hantei2 = true;
			}
		if(hantei == true){
			if (col.gameObject.tag == "righthand"){
				hantei3 = true;
			}
			if(hantei2 == true){
				if(col.gameObject.tag == "lefthand"){
					hantei5 = true;
				}
			}
		}
		}
	}
	public void OnTriggerExit(Collider col){
		hantei = false;
		hantei2 = false;
	}
	/*	public void OnTriggerEnter(Collider col){
		if(hantei == true){
		if (col.gameObject.tag == "righthand"){
			hantei3 = true;
			}
		if(hantei2 == true){
				if(col.gameObject.tag == "lefthand"){
					hantei5 = true;
				}
			}
	}
		}*/
}
