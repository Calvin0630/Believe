﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour {
    private float batteryLevel;
    private float efficiency;
    public Light flashLight;
	// Use this for initialization
	void Start () {
        batteryLevel = 100;
        efficiency = 0.6f;
	}
	
	// Update is called once per frame
	void Update () {
		if (batteryLevel > 0)
        {
            batteryLevel -= (efficiency * Time.deltaTime);
            flashLight.intensity = batteryLevel / 100;
        }
        print(batteryLevel);
	}
}
