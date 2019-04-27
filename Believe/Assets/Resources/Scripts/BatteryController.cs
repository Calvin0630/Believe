using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryController : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "Player") {
            FlashLightController light = other.gameObject.GetComponentInChildren<FlashLightController>();
            light.ConsumeBattery();
            Destroy(gameObject);
        }
    }
}