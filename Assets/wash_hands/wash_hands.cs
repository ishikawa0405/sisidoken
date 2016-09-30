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
		if (M_Timer >= 6.0f) {
			if (hantei3 == true && hantei4 == false) {
				Instantiate (S_wash, new Vector3 (28.11f, 12.35f, 16.12f), Quaternion.identity);
				S_Open Seikai = refObj.GetComponent<S_Open> ();
				Seikai.Sound ();
				hantei4 = true;
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
		}
	}
	public void OnTriggerExit(Collider col){
		hantei = false;
		hantei2 = false;
	}
		public void OnTriggerEnter(Collider col){
		if(hantei == true){
		if (col.gameObject.tag == "righthand"){
			hantei3 = true;
			}
		if(hantei2 == true){
				if(col.gameObject.tag == "lefthand"){
					hantei3 = true;
				}
			}
	}
		}
}
