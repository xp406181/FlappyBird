using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour {
	Rigidbody m_rigid;
	public float m_VX = 5.0f;
	public float m_VY = 3.0f;
	// Use this for initialization
	void Start () {
		m_rigid = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Fire1")){
			this.m_rigid.velocity = new Vector3(m_VX,m_VY,0);
		}
	}
}
