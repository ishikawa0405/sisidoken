using UnityEngine;
using System.Collections;

public class Collision_Detection : MonoBehaviour{
	bool hantei = false;
	bool hantei2 = false;
	public GameObject refObj;
	float SitDown_myTimer = 0.0f;
	// Use this for initialization
	void Start () {
	
	}

	void Update() {
		Debug.Log (hantei2);
		if (hantei2 == true) {
			//Debug.Log (base.bones[4].transform.position);
			//Collision_Detection Apple = refObj2.GetComponent<Collision_Detection> ();
			//Apple.OnControllerColliderHit();
			if (hantei == false) {
				hantei = true;
				Move_Test CubeTest = refObj.GetComponent<Move_Test> ();
				CubeTest.Sound ();
				CubeTest.Move ();
				//CubeTest.SoundStop();
			}
			//Move_Test CubeTest2 = gameObject.GetComponent<Move_Test>();
			//CubeTest2.Stop ();
		}else {
			Move_Test CubeTest = refObj.GetComponent<Move_Test>();
			CubeTest.Move2();
		}
		
		
		
		if(hantei == true){
			SitDown_myTimer += Time.deltaTime;
			if(SitDown_myTimer >=3){
				Application.LoadLevel("Rejoice_Taich4");
				//DontDestroyOnLoad();
			}
		}
	}
	
	// Update is called once per frame
	public void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Player") {
			hantei2 = true;
	}
}

}