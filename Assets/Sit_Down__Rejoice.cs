using UnityEngine;
using System.Collections;

public class Sit_Down__Rejoice : MonoBehaviour {
	//private static bool created = false;
	float myTimer = 0.0f;
	// Use this for initialization
	/*void Awake() {
		DontDestroyOnLoad(transform.gameObject);
	}*/
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		myTimer += Time.deltaTime;
		if(myTimer >=10){{
				Application.LoadLevel("Rejoice_Taich");
				//DontDestroyOnLoad();
			}
		}
	}
}
