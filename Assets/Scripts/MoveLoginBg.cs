using UnityEngine;
using System.Collections;

public class MoveLoginBg : MonoBehaviour {
	public float moveX = -1f;
	Rigidbody rigid;
	// Use this for initialization
	void Start () {
		this.rigid = this.GetComponent<Rigidbody>();
		this.rigid.velocity = new Vector3(moveX,0,0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		//		Debug.Log("-------------------");
		if(other.tag == "WorldBound"){
			this.transform.position = this.transform.position + new Vector3(30f,0,0);
		}
	}
}
