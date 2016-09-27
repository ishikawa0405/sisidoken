using UnityEngine;
using System.Collections;

public class Nmovecamera : MonoBehaviour {

		Camera mainCamera;//メインカメラ
		Camera subCamera;//サブのカメラです
		float myTimer = 0.0f;
		// Use this for initialization
		void Start () {
			mainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
			subCamera = GameObject.Find ("Sub Camera").GetComponent<Camera> ();
			
			subCamera.enabled = false;
			
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
			if(myTimer >=10
		   ){
				mainCamera.enabled = false;
				subCamera.enabled = true;
			}else{
				mainCamera.enabled = true;
				subCamera.enabled = false;
			}
		}
	}
