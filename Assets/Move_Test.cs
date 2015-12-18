using UnityEngine;
using System.Collections;

public class Move_Test : MonoBehaviour {
	public AudioClip audioClip1;
	private AudioSource audioSource;
	// Use this for initialization
	void Start () {
		audioSource = gameObject.GetComponent<AudioSource>();
		audioSource.clip = audioClip1;
	}
	public void Move () {
		iTween.MoveTo(gameObject,new Vector3(0.3f, 2.5f, -7.57f), 0.5f);
	}
	public void Move2(){
		iTween.MoveTo(gameObject,new Vector3(0, 100, -8), 0.5f);
	}
	public void Sound(){
			audioSource.Play ();
	}
	public void SoundStop(){
		audioSource.Stop ();
	}
	public void Stop(){
		gameObject.GetComponent<Move_Test>().enabled = false;
	}
}
