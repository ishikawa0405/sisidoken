using UnityEngine;
using System.Collections;

public class Move_Test : MonoBehaviour {

	// Use this for initialization
public void Move () {
		iTween.MoveTo(gameObject,new Vector3(0.3f, 2.5f, -7.57f), 0.5f);
	}
	public void Move2(){
		iTween.MoveTo(gameObject,new Vector3(0, 100, -8), 0.5f);
	}
}
