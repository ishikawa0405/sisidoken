using UnityEngine;
using System.Collections;

public class Turn_off_the_light : MonoBehaviour {
	public GameObject refObj;
	public GameObject S_Off_light;
	float M_Timer = 0.0f;
	//transform.rotation = Quaternion.Euler(0, 332.454f, 0);
	bool hantei = false;
	bool hantei2 = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		M_Timer += Time.deltaTime;
		if (hantei == true && hantei2 == false) {
			Instantiate(S_Off_light, new Vector3(24.58f, 29.49f, 41.84f), Quaternion.Euler (0, 33.840f, 0));
			S_Open Seikai = refObj.GetComponent<S_Open>();
			Seikai.Sound ();
			hantei2 = true;
		}
	}
	public void OnTriggerEnter(Collider col){
		if (M_Timer >= 6.0f) {
			if (col.gameObject.tag == "Player") {
				hantei = true;
			}
		}
	}
}

