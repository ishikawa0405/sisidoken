using UnityEngine;
using System.Collections;

public class ShitDown : MonoBehaviour {
	float myTimer = 0.0f;
	bool flag = false;
	public AudioClip audioClip1;
	private AudioSource audioSource;
	// Use this for initialization
	void Start () {
		audioSource = gameObject.GetComponent<AudioSource> ();
		audioSource.clip = audioClip1;
	}
	
	// Update is called once per frame
	void Update () {
		myTimer += Time.deltaTime;
		if (myTimer >= 7) {
			if (flag == false) 
			{
				flag = true;
				audioSource.Play ();
			}
		}
	}
}
