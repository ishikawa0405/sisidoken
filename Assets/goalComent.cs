using UnityEngine;
using System.Collections;

public class goalComent : MonoBehaviour {
	float myTimer = 0.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		myTimer += Time.deltaTime;
		if(myTimer >=3){{
				transform.position = Vector3.MoveTowards (transform.position , 
				                                          new Vector3( -188.2f, 271.4f, -447.6f) , 5.0f);   //絶対座標の(10,10,10)に向かって0.1移動させる
			}
		}
	}
}
