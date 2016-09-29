using UnityEngine;
using System.Collections;

public class garbage : MonoBehaviour {
	float M_Timer = 0.0f;
	float M_Timer2 = 0.0f;
	bool hantei = false;
	bool hantei2 = false;
	bool hantei3 = false;
	bool hantei4 = false;
	bool hantei5 = false;
	public GameObject player;
	public GameObject trash;
	public GameObject refObj;
	public GameObject S_Open;
	GameObject Pre_Seikai;
	int i = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		M_Timer += Time.deltaTime;
		if (hantei == true ) {
			M_Timer2 += Time.deltaTime;
			transform.position = new Vector3(player.transform.position.x - 0.15f , player.transform.position.y - 0.15f , player.transform.position.z);
			if(hantei5 == false){
				Pre_Seikai = (GameObject)Instantiate (S_Open, new Vector3 (-7.1f, 1.8f, 87.8f), Quaternion.Euler(0, -90f, 0));
				hantei5 = true;
			}
			if(M_Timer2 >= 1.0f ){
				GameObject.Destroy(Pre_Seikai);
			}
			if(hantei3 == false){
			S_Open Seikai = refObj.GetComponent<S_Open>();
			Seikai.Sound ();
			hantei3 = true;
			}
		}
		if (hantei2 == true && hantei4 == false) {
			Destroy(gameObject);
			S_Open Seikai = refObj.GetComponent<S_Open>();
			Seikai.Sound ();
			hantei4 = true;
			Pre_Seikai = (GameObject)Instantiate (S_Open, new Vector3 (-7.1f, 1.8f, 87.8f), Quaternion.Euler(0, -90f, 0));
		}
	}
	public void OnTriggerEnter(Collider col){
		if (M_Timer >= 6.0f) {
			if (col.gameObject.tag == "Player") {
				hantei = true;
			}
			if (col.gameObject.tag == "trash") {
				hantei2 = true;
			}
		}
	}
}
