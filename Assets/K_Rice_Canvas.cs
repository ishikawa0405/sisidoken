using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class K_Rice_Canvas : MonoBehaviour {//誤爆
	float myTimer = 0.0f;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		myTimer += Time.deltaTime;
		if(myTimer >=4){{
				this.GetComponent<Text>().text = "もんだい!";
			}
			if(myTimer >=7){{
					this.GetComponent<Text>().text = "よくきいて♪♪";
				}
				if(myTimer >=10){{
						this.GetComponent<Text>().text = "ポーズをとろう!";
						
					}
				}
			}
		}	
	}
}