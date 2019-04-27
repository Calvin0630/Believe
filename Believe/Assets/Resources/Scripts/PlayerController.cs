using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float playerSpeed;
    GameObject flashLight;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 deltaDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * playerSpeed;
        gameObject.transform.Translate(deltaDir);
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPos.y = gameObject.transform.position.y;
        Vector3 lookDir = mouseWorldPos - gameObject.transform.position;
        if (lookDir.magnitude>0.5) gameObject.transform.forward = lookDir.normalized;
        //gameObject.transform.LookAt(mouseWorldPos);

    }
}