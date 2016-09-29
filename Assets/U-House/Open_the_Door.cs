using UnityEngine;
using System.Collections;

public class Open_the_Door : MonoBehaviour {
	public GameObject lefthand;
	public GameObject righthand;
	bool hantei = false;
	Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (hantei);
		if (hantei == true) {
			animator.Play ("Open");
		}
	}

	public void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Player") {
			hantei = true;
		}
	}

}
