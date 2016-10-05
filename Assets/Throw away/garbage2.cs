using UnityEngine;
using System.Collections;

public class garbage2 : MonoBehaviour {
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
	public GameObject Hint;
	GameObject Pre_Seikai;
	int i = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		M_Timer += Time.deltaTime;
		transform.position = new Vector3 (player.transform.position.x - 0.15f, player.transform.position.y - 0.15f, player.transform.position.z);
		if (hantei2 == true && hantei4 == false) {
			Destroy(gameObject);
			S_Open Seikai = refObj.GetComponent<S_Open>();
			Seikai.Sound ();
			hantei4 = true;
			Pre_Seikai = (GameObject)Instantiate (S_Open, new Vector3 (-6.97f, 1.97f, 86.89f), Quaternion.Euler (0, 201.475f, 0));
		}
		if (M_Timer >= 27f) {
			Instantiate (Hint, new Vector3 (-7.01f, 2.42f, 87.69f), Quaternion.Euler (13.581f, 210.57f, 3.6465f));
		}
		}
	public void OnTriggerEnter(Collider col){
	/*	
	if (M_Timer >= 6.0f) {
			if (col.gameObject.tag == "Player") {
				hantei = true;
			}
			*/
		if (M_Timer >= 6.0f) {
			if (col.gameObject.tag == "trash") {
				hantei2 = true;
			}
		}
		}
}
