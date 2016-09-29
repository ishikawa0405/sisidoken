using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeCamera2 : MonoBehaviour {
	Camera mainCamera;//メインカメラ
	Camera subCamera;//サブのカメラです
	Camera subsubCamera;//サブサブのカメラです
	float myTimer = 0.0f;
	// Use this for initialization
	void Start () {
		mainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
		subCamera = GameObject.Find ("Sub Camera").GetComponent<Camera> ();
		subsubCamera = GameObject.Find ("SubSubCamera").GetComponent<Camera> ();
		
		subCamera.enabled = false;
		subsubCamera.enabled = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		// Spaceキーで切り替え
		/*if (Input.GetKeyDown(KeyCode.Space))
		{
			if(mainCamera.enabled){
				mainCamera.enabled = false;
				subCamera.enabled = true;
			}else{
				mainCamera.enabled = true;
				subCamera.enabled = false;
			}
		}*/ 
		myTimer += Time.deltaTime;
		if(myTimer >=10 && myTimer < 20){
			mainCamera.enabled = false;
			subCamera.enabled = true;
			subsubCamera.enabled = false;
		}else if(myTimer >=20){
			mainCamera.enabled = false;
			subCamera.enabled = false;
			subsubCamera.enabled = true;
		}else{
			mainCamera.enabled = true;
			subCamera.enabled = false;
			subsubCamera.enabled = false;
		}
	}
}