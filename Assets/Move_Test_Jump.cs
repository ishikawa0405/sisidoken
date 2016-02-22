using UnityEngine;
using System.Collections;

public class Move_Test_Jump : MonoBehaviour {
	public AudioClip audioClip1;
	private AudioSource audioSource;
	// Use this for initialization
	void Start () {
		audioSource = gameObject.GetComponent<AudioSource>();
		audioSource.clip = audioClip1;
	}
	public void Move () {
		iTween.MoveTo(gameObject,new Vector3(-1.08f, 2.58f, -0.15f), 0.5f);
	}
	public void Move2(){
		iTween.MoveTo(gameObject,new Vector3(-1.08f, 8.99f, -0.15f), 0.5f);
	}
	public void Sound(){
		audioSource.Play ();
	}
	public void SoundStop(){
		audioSource.Stop ();
	}
	public void Stop(){
		gameObject.GetComponent<Move_Test_Jump>().enabled = false;
	}
}
