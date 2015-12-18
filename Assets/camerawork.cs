using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {
	
	public GameObject player;
	private Transform playerTrans;
	
	void Start (){
		//プレイヤーの位置情報をキャッシュ
		playerTrans = player.GetComponent<Transform>();
	}
	
	void Update (){
		//カメラの操作
		/*Vector3 camVec = this.transform.position;
		camVec.y += camHeight;
		camVec.z += camDistance;
		MainCamera.transform.position = camVec;
		MainCamera.transform.LookAt(this.transform);*/
}
}