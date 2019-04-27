using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayNightCycle : MonoBehaviour {
    private float speed;
    public Text clock;
    public int currentHour;
    private float time;
	// Use this for initialization
	void Start () {
        speed = 3f;
        time = 0;
        currentHour = 12;
        clock.text = currentHour + ": 00";
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(Vector3.zero, Vector3.left, speed * Time.deltaTime);
        transform.LookAt(Vector3.zero);
        time += Time.deltaTime;
        if (time >= 5)
        {
            time = 0;
            currentHour++;
            if (currentHour == 24)
                currentHour = 0;
        }
        clock.text = currentHour + ": 00";
    }
}
