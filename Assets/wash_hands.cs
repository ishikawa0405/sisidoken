using UnityEngine;
using System.Collections;

public class wash_hands : MonoBehaviour {
	bool hantei = false;
	bool hantei2 = false;
	bool hantei3 = false;
	public GameObject lefthand;
	public GameObject righthand;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (hantei3);
	}
	public void OnTriggerStay(Collider col){
		if (col.gameObject.tag == "lefthand") {
			hantei = true;
		} 
		if (col.gameObject.tag == "righthand") {
			hantei2 = true;
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
