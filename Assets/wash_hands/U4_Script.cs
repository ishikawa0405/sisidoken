using UnityEngine;
using System.Collections;

public class U4_Script : MonoBehaviour {
	public GameObject House_Mondai;
	public GameObject listen;
	public GameObject Hint;
	float M_Timer = 0.0f;
	bool hantei = false;
	bool hantei2 = false;
	GameObject Prehub_mondai;
	GameObject Prehub_listen;
	// Use this for initialization
	void Start () {
		Prehub_mondai = (GameObject)Instantiate (House_Mondai, new Vector3 (25.89f, 10.95f, 14.92f), Quaternion.Euler (0, 90f, 0));
	}
	
	// Update is called once per frame
	void Update () {
		M_Timer += Time.deltaTime;
		if (M_Timer >= 2.0f && M_Timer < 4.0f) {
			GameObject.Destroy(Prehub_mondai);
		}
		if (M_Timer >= 4.0f && M_Timer < 6.0f && hantei == false) {
			Prehub_listen = (GameObject)Instantiate (listen, new Vector3 (25.89f, 10.95f, 14.92f), Quaternion.Euler (0, 90f, 0));
			hantei = true;
		}
		if (M_Timer >= 6.0f && hantei == true) {
			GameObject.Destroy(Prehub_listen);
		}
		if (M_Timer >= 27f && hantei2 == false) {
			Instantiate (Hint, new Vector3 (24.81f, 11.12f, 16.63f), Quaternion.Euler (44.8086f, 83.6247f, 349.235f));
			hantei2 = true;
		}
	}
}
