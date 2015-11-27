#pragma strict
	var myTimer : float = 0.0;
	//private static var created =false;
function Start () {

}
/*function Awake () {
    if(!created){
        DontDestroyOnLoad (this.gameObject);
        created=true;
    }else{
        Destroy(this.gameObject);
    }
}*/
function Update () {
	myTimer += Time.deltaTime;
	if(myTimer >=5.0){
	
	GetComponent.<Animator>().Play("walk");
	}
	/*if(myTimer >=9.0){
	
	GetComponent.<Animator>().Play("wate");
	}*/
}