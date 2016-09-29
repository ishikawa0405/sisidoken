using UnityEngine;
using System.Collections;

public class Apple_Cmera : MonoBehaviour {
	float myTimer = 0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		myTimer += Time.deltaTime;
		if(myTimer >=8){{
				transform.position = Vector3.MoveTowards (transform.position , 
				                                          new Vector3( 4.01f, 3.00f, -1.52f) , 0.4f);   //絶対座標の(10,10,10)に向かって0.1移動させる
			}
		}
	}
}
