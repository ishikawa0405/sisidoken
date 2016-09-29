using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NewbehaviourScript3 : MonoBehaviour {
	Camera mainCamera;//メインカメラ
	Camera Camera;//サブのカメラです
	float myTimer = 0.0f;
	// Use this for initialization
	void Start () {
		mainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
		Camera = GameObject.Find ("Camera").GetComponent<Camera> ();
		
		Camera.enabled = false;
		
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
		if(myTimer >=2){
			mainCamera.enabled = false;
			Camera.enabled = true;
		}else{
			mainCamera.enabled = true;
			Camera.enabled = false;
		}
	}
}







