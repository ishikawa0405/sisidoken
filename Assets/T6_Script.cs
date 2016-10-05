using UnityEngine;
using System.Collections;

public class T6_Script : MonoBehaviour {
	public GameObject House_Mondai;
	public GameObject listen;
	float M_Timer = 0.0f;
	bool hantei = false;
	GameObject Prehub_mondai;
	GameObject Prehub_listen;
	// Use this for initialization
	void Start () {
		Prehub_mondai = (GameObject)Instantiate (House_Mondai, new Vector3 (997.2f, -66.1f, -25.5f), Quaternion.Euler (0, 17.24361f, 0));
	}
	
	// Update is called once per frame
	void Update () {
		M_Timer += Time.deltaTime;
		if (M_Timer >= 2.0f && M_Timer < 4.0f) {
			GameObject.Destroy(Prehub_mondai);
		}
		if (M_Timer >= 4.0f && M_Timer < 6.0f && hantei == false) {
			Prehub_listen = (GameObject)Instantiate (listen, new Vector3 (997.2f, -66.1f, -25.5f), Quaternion.Euler (0, 17.24361f, 0));
			hantei = true;
		}
		if (M_Timer >= 6.0f && hantei == true) {
			GameObject.Destroy(Prehub_listen);
		}
	}
	}
