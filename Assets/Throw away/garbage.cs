using UnityEngine;
using System.Collections;

public class garbage : MonoBehaviour {
	bool hantei = false;
	bool hantei2 = false;
	public GameObject player;
	public GameObject trash;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (hantei == true) {
			transform.position = new Vector3(player.transform.position.x + 0.1f , player.transform.position.y - 0.1f , player.transform.position.z );

		}
		if (hantei2 == true) {
			Destroy(gameObject);
		}
	}
	public void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Player") {
			hantei = true;
		}
		if (col.gameObject.tag == "trash") {
			hantei2 = true;
		}
	}
	
}
