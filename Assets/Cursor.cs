using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour {

    CameraRaycaster cameraRaycaster;
    int LEFT_CLICK = 0;

	// Use this for initialization
	void Start () {
        cameraRaycaster = GetComponent<CameraRaycaster>();
	}
	
	// Update is called once per frame
	void Update () {

	}
}
