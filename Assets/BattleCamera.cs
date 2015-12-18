using UnityEngine;
using System.Collections;

public class BattleCamera : MonoBehaviour {
	float myTimer = 0.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		myTimer += Time.deltaTime;
		if(myTimer >=8){{
				transform.position = Vector3.MoveTowards (transform.position , 
			     new Vector3( -364.8f, 135f, -147.3f) , 1.0f);   //絶対座標の(10,10,10)に向かって0.1移動させる
	}
}
	}
}