using UnityEngine;
using System.Collections;

public class S_Open : MonoBehaviour {
	public AudioClip audioClip1;
	private AudioSource audioSource;
	// Use this for initialization
	void Start () {
		audioSource = gameObject.GetComponent<AudioSource>();
		audioSource.clip = audioClip1;
	}
	public void Sound(){
		audioSource.Play ();
	}
	public void SoundStop(){
		audioSource.Stop ();
	}
	// Update is called once per frame
	void Update () {
	
	}
}
