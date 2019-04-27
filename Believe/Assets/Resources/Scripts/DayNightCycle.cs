using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour {
    private float speed;
	// Use this for initialization
	void Start () {
<<<<<<< HEAD
        speed = 3f;
=======
        speed = 0.8f;
>>>>>>> dd459158f25d43406fef2ded8fb0f17bc4646372
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(Vector3.zero, Vector3.forward, speed * Time.deltaTime);
        transform.LookAt(Vector3.zero);
	}
}
