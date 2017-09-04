using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {

    private bool called;
    private Rigidbody rigiBody;

	void Start () {
        rigiBody = GetComponent<Rigidbody>();
    }
	
    public void OnDispatchHelicopter()
    {
        rigiBody.velocity = new Vector3(0,0,50f);
        called = true;

    }
}
