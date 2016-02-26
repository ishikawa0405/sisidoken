using UnityEngine;
using System.Collections;

public class Rejoice_Camera : MonoBehaviour {
	float myTimer = 0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		myTimer += Time.deltaTime;
		if(myTimer >=2){{
				transform.position = Vector3.MoveTowards (transform.position , 
				                                          new Vector3( -1.01f, 2.48f, 1.72f) , 0.4f);   //絶対座標の(10,10,10)に向かって0.1移動させる
			}
		}
	}
}