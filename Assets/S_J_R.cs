using UnityEngine;
using System.Collections;

public class S_J_R : AvatarController {
	bool hantei_S = false;
	bool hantei_J = false;
	bool hantei_J2 = false;
	bool hantei_R = false;
	bool hantei_M = false;
	bool hantei_M2 = false;
	bool hantei_M3 = false;
	public GameObject refObj;
	float S_myTimer = 0.0f;
	float J_myTimer = 0.0f;
	float R_myTimer = 0.0f;
	int i = 0;
	// Use this for initialization
	void Start () {
		Move_Test CubeTest = refObj.GetComponent<Move_Test> ();
		CubeTest.Move2 ();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (base.bones[4].transform.position);
		Move_Test CubeTest = refObj.GetComponent<Move_Test> ();
		if (base.bones [4].transform.position.y < 1.6) {
			if (hantei_S == false) {
				CubeTest.Sound ();
				CubeTest.Move ();
				hantei_S = true;
			}
			//CubeTest.SoundStop();
		} else if (base.bones [4].transform.position.y > 1.9 && hantei_S == true) {
			hantei_J2 = true;
		} else if (hantei_J == false && hantei_S == true && hantei_J2 == true) {
				//Move_Test CubeTest = refObj.GetComponent<Move_Test> ();
				J_myTimer += Time.deltaTime;
				hantei_M = true;
				CubeTest.Sound ();
				CubeTest.Move ();
			if(J_myTimer >=3){
				hantei_J = true;
				hantei_M2 = true;
			}
			} else if (hantei_S == true && hantei_M == false) {
				CubeTest.Move2 ();
			} else if (base.bones [7].transform.position.y > 2.0) {
			if( hantei_J == true && hantei_R == false){
			    hantei_R = true;
				hantei_M3 = true;
				CubeTest.Move ();
				CubeTest.Sound ();
			}
		} else if (hantei_J == true && hantei_M == true && hantei_M2 == true && hantei_M3 == false) {
			CubeTest.Move2 ();
		}
	}}
