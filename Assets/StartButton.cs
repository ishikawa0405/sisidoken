using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour {
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
		Application.LoadLevel("SeenChangPuroto");
	}
}