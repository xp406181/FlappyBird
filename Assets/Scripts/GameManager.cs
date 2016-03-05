using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	Transform m_BridTrans;
	public Transform m_FirstBg;
	float m_DefaultDiffX = 3f;
	float m_DefaultDiffY = -2.5f;
	float m_DefaultDiffZ  = -9.5f;

	float m_MaxY = 1.36f;
	float m_MinY = -1.39f;
	// Use this for initialization
	void Start () {
		m_BridTrans = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 newPos = new Vector3(m_BridTrans.position.x + m_DefaultDiffX,m_BridTrans.position.y + m_DefaultDiffY, m_BridTrans.position.z + m_DefaultDiffZ);
		if(newPos.y > m_MaxY)
		{
			newPos.y = m_MaxY;
		}

		if(newPos.y < m_MinY)
		{
			newPos.y = m_MinY;
		}

		this.transform.position = newPos;
	}
}
