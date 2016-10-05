using UnityEngine;
using System.Collections;

public class U6_Script : MonoBehaviour {
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
		Prehub_mondai = (GameObject)Instantiate (House_Mondai, new Vector3 (24.58f, 30.25f, 41.84f), Quaternion.Euler (0, 33.840f, 0));
	}
	
	// Update is called once per frame
	void Update () {
		M_Timer += Time.deltaTime;
		if (M_Timer >= 2.0f && M_Timer < 4.0f) {
			GameObject.Destroy(Prehub_mondai);
		}
		if (M_Timer >= 4.0f && M_Timer < 6.0f && hantei == false) {
			Prehub_listen = (GameObject)Instantiate (listen, new Vector3 (24.58f, 30.25f, 41.84f), Quaternion.Euler (0, 33.840f, 0));
			hantei = true;
		}
		if (M_Timer >= 6.0f && hantei == true) {
			GameObject.Destroy(Prehub_listen);
		}
		if (M_Timer >= 27f && hantei2 == false) {
			Instantiate (Hint, new Vector3 (25.71f, 31.61f, 47.23f), Quaternion.Euler (0, 35.3138f, 0));
			hantei2 = true;
		}
	}
}
