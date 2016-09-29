using UnityEngine;
using System.Collections;

public class U_Story_Script : MonoBehaviour {
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
	int y = 1;
	int i = 0;
	GameObject Prehub;
	float M_Timer = 0.0f;
	bool hantei = false;
	// Use this for initialization
	void Start () {
		GameObject[] H = {S1, S2, S3, S4, S5, S6, S7, S8, S9, S10, S11};
		Prehub = (GameObject)Instantiate (H[i], new Vector3 (0,5f,0), Quaternion.identity);
		StartCoroutine ("Auto");
	}
	
	// Update is called once per frame
	void Update () {
		M_Timer += Time.deltaTime;
	}
	public IEnumerator Auto() {
			while (true) {
			yield return new WaitForSeconds (3.0f);
			Process();
			if(y == 12){
				yield break;
			}
		}
		}
	  void Process() {
		GameObject.Destroy (Prehub);
		GameObject[] H = {S1, S2, S3, S4, S5, S6, S7, S8, S9, S10, S11};
		Prehub = (GameObject)Instantiate (H[y], new Vector3 (0,5f,0), Quaternion.identity);
		y = y + 1;
	}
}
