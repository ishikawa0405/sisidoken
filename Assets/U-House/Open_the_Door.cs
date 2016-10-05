using UnityEngine;
using System.Collections;

public class Open_the_Door : MonoBehaviour {
	public GameObject refObj;
	bool hantei = false;
	bool hantei2 = false;
	Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (hantei);
		if (hantei == true && hantei2 == false) {
			animator.Play ("Open");
			S_Open Seikai = refObj.GetComponent<S_Open>();
			Seikai.Sound ();
			hantei2 = true;
		}
	}

	public void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Player") {
			hantei = true;
		}
	}

}
