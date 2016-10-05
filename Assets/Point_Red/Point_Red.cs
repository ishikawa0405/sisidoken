using UnityEngine;
using System.Collections;

public class Point_Red : MonoBehaviour {
	public GameObject refObj;
	public GameObject S_Point;
	public GameObject Hint;
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
			Instantiate(S_Point, new Vector3(997.33f, -66.88f,-26.8f),  Quaternion.Euler(0, 24.81616f, 0));
			S_Open Seikai = refObj.GetComponent<S_Open>();
			Seikai.Sound ();
			hantei2 = true;
		}
		if (M_Timer >= 27f) {
			Instantiate(Hint, new Vector3(996.03f, -66.81f,-28.35f),  Quaternion.Euler(-0.6959f, 12.1717f, 1.00857f));
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
