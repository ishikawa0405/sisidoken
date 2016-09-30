using UnityEngine;
using System.Collections;

public class StoryKon : MonoBehaviour {
	GameObject [] H;
	public GameObject S1;
	public GameObject S2;
	public GameObject S3;
	public GameObject S4;
	public GameObject S5;
	public GameObject S6;
	public GameObject S7;
	public GameObject S8;
	public GameObject S9;
	public GameObject S10;
	public GameObject S11;
	public GameObject S12;
	public GameObject S13;
	public GameObject S14;
	public GameObject S15;
	public GameObject S16;
	public GameObject S17;
	public GameObject S18;
	public GameObject S19;
	int y = 1;
	int i = 0;
	GameObject Prehub;
	float M_Timer = 0.0f;
	bool hantei = false;
	// Use this for initialization
	void Start () {
		GameObject[] H = {S1, S2, S3, S4, S5, S6, S7, S8, S9, S10, S11, S12, S13, S14, S15, S16, S17, S18, S19};
		Prehub = (GameObject)Instantiate (H[i], new Vector3 (0,5f,0), Quaternion.identity);
		StartCoroutine ("Auto");
	}
	
	// Update is called once per frame
	void Update () {
		M_Timer += Time.deltaTime;
	}
	public IEnumerator Auto() {
		while (true) {
			yield return new WaitForSeconds (4.0f);
			Process();
			if(y == 20){
				yield break;
			}
		}
	}
	void Process() {
		GameObject.Destroy (Prehub);
		GameObject[] H = {S1, S2, S3, S4, S5, S6, S7, S8, S9, S10, S11, S12, S13, S14, S15, S16, S17, S18, S19};
		Prehub = (GameObject)Instantiate (H[y], new Vector3 (0,5f,0), Quaternion.identity);
		y = y + 1;
	}
}
