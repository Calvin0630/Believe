using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this is a script to make the camera follow the player
public class CameraController : MonoBehaviour {
    public GameObject target;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 targetPos = target.transform.position;
        gameObject.transform.position = new Vector3(targetPos.x, gameObject.transform.position.y, targetPos.z);

	}
}
