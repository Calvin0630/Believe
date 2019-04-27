using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour {
    private float speed;
	// Use this for initialization
	void Start () {
        speed = 3f;
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(Vector3.zero, Vector3.forward, speed * Time.deltaTime);
        transform.LookAt(Vector3.zero);
	}
}
