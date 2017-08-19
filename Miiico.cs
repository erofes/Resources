using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miiico : MonoBehaviour {
    public Rigidbody m_rb;
	// Use this for initialization
	void Start () {
        m_rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        m_rb.AddTorque(0.1f, 0.1f, 0.1f, ForceMode.Acceleration);
    }
}
