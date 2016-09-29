using UnityEngine;
using System.Collections;

public class asobikata : MonoBehaviour {
	public GameObject asobikata1;
	public GameObject asobikata2;
	public GameObject asobikata3;
	public GameObject asobikata4;
	public GameObject asobikata5;
	public GameObject asobikata6;
	GameObject Prehub;
	int i = 0;
	// Use this for initialization
	void Start () {
		Prehub = (GameObject)Instantiate (asobikata1, new Vector3 (0,0.81f,0), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (i);
	}
	public void Click() {
		i = i + 1;
		if (i == 1) {
			GameObject.Destroy (Prehub);
			Prehub = (GameObject)Instantiate (asobikata2, new Vector3 (0,0.81f,0), Quaternion.identity);
		}
		if (i == 2) {
			GameObject.Destroy (Prehub);
			Prehub = (GameObject)Instantiate (asobikata3, new Vector3 (0,0.81f,0), Quaternion.identity);
		}
		if (i == 3) {
			GameObject.Destroy (Prehub);
			Prehub = (GameObject)Instantiate (asobikata4, new Vector3 (0,0.81f,0), Quaternion.identity);
		}
		if (i == 4) {
			GameObject.Destroy (Prehub);
			Prehub = (GameObject)Instantiate (asobikata5, new Vector3 (0,0.81f,0), Quaternion.identity);
		}
		if (i == 5) {
			GameObject.Destroy (Prehub);
			Prehub = (GameObject)Instantiate (asobikata6, new Vector3 (0,0.81f,0), Quaternion.identity);
		}
		if (i >= 6) {
			GameObject.Destroy (Prehub);
		}
	}
}
