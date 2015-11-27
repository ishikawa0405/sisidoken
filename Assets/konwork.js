#pragma strict
	
	public var power : float = 1.0;
	private var target : GameObject;
function Start () {
	target = GameObject.FindGameObjectWithTag("Cubee");
	
}

function Update () {
	
	while (transform.position.x != -227 ){
	var direction : Vector3 = ((target.transform.position - transform.position)/20) ;
	
	
	}
	/*if (Input.GetKey("down")) {
		transform.position.z -= power;
	}*/
	GetComponent.<Rigidbody>().
		AddForce(direction.normalized * power);
	
}
	
	
		
		//transform.LookAt(direction);
