using UnityEngine;
using System.Collections;

public class Jump : AvatarController {
	bool hantei = false;
	public GameObject refObj;
	float Jump_myTimer = 0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (base.bones[4].transform.position);
		if (base.bones [4].transform.position.y > 2.15) {
			if (hantei == false) 
			{
				hantei = true;
				Move_Test CubeTest = refObj.GetComponent<Move_Test>();
				CubeTest.Sound();
				CubeTest.Move();
				//CubeTest.SoundStop();
			}
			//Move_Test CubeTest2 = gameObject.GetComponent<Move_Test>();
			//CubeTest2.Stop ();
		} else {
			Move_Test CubeTest = refObj.GetComponent<Move_Test>();
			CubeTest.Move2();
		}
		if(hantei == true){
			Jump_myTimer += Time.deltaTime;
			if(Jump_myTimer >=3){
				Application.LoadLevel("Rejoice_Taich");
				//DontDestroyOnLoad();
			}
		}
	}
}
