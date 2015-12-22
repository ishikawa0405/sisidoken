using UnityEngine;
using System.Collections;

public class Sound : MonoBehaviour {
	public AudioClip audioClip1;
	private AudioSource audioSource;
	// Use this for initialization
	void Start () {
		audioSource = gameObject.GetComponent<AudioSource> ();
		audioSource.clip = audioClip1;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.R)){
			audioSource.Play ();
		}
	}
}
