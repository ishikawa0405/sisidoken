using UnityEngine;
using System.Collections;

public class U2_Script : MonoBehaviour {
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
		Prehub_mondai = (GameObject)Instantiate (House_Mondai, new Vector3 (35.1f, 12.2f, 27.2f), Quaternion.Euler (0, 260.8065f, 0));
	}
	
	// Update is called once per frame
	void Update () {
		M_Timer += Time.deltaTime;
		if (M_Timer >= 2.0f && M_Timer < 4.0f) {
			GameObject.Destroy(Prehub_mondai);
		}
		if (M_Timer >= 4.0f && M_Timer < 6.0f && hantei == false) {
			Prehub_listen = (GameObject)Instantiate (listen, new Vector3 (35.1f, 12.2f, 27.2f), Quaternion.Euler (0, 260.8065f, 0));
			hantei = true;
		}
		if (M_Timer >= 6.0f && hantei == true) {
			GameObject.Destroy(Prehub_listen);
		}
		if (M_Timer >= 27f && hantei2 == false) {
			Instantiate (Hint, new Vector3 (36.63f, 11.2f, 30.36f), Quaternion.Euler (0, -96.449f, 0));
			hantei2 = true;
		}
	}
}
