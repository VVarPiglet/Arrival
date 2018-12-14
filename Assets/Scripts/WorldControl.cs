using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldControl : MonoBehaviour {
    Vector3 currentClickTarget;
    public GameObject Sprout;

    // Use this for initialization
    void Start () {
        currentClickTarget = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 origin = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,
                                          Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
            RaycastHit2D hit = Physics2D.Raycast(origin, Vector2.zero, 0f);
            if (hit)
            {
                var hitObjectTransform = hit.transform;
                print(hit.transform.gameObject.tag);
                print("cords: " + origin.ToString());

                Instantiate(Sprout, new Vector3(origin.x, origin.y, 0), hitObjectTransform.rotation);
            }
        }
    }
}
