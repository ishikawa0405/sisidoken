using UnityEngine;
using System.Collections;

public class OpenKeep : MonoBehaviour {
		Animator animator;
		float myTimer = 0.0f;
		bool hantei = false;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (hantei);
		myTimer += Time.deltaTime;
		if (myTimer >= 15 && hantei == false) {
			animator.Play ("U-roomOpen");
			hantei = true;
		}
	}
}
