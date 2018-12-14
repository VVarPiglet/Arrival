using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float moveSpeed = 1.0f;

    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Single axisRawHorizontal = Input.GetAxisRaw("Horizontal");
        Single axisRawVertical = Input.GetAxisRaw("Vertical");

		if(axisRawHorizontal > 0.5f || axisRawHorizontal < -0.5f)
        {
            transform.Translate(new Vector3(axisRawHorizontal * moveSpeed * Time.deltaTime, 0f, 0f));
        }

        if(axisRawVertical > 0.5f || axisRawVertical < -0.5f)
        {
            transform.Translate(new Vector3(0f, axisRawVertical * moveSpeed * Time.deltaTime, 0f));
        }

	}
}
