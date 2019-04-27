using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashLightController : MonoBehaviour {
    //0 is empty, 1 is charged
    public float batteryLevel;
    //in seconds
    public float batteryDuration;
    Light flashLight;
    public GameObject lightSliderObject;
    Slider lightSlider;
    public GameObject sliderFillObject;
    Image sliderFill;
    public Color sliderActiveColor, sliderInactiveColor;
    public bool flashLightEnabled;
    // Use this for initialization
    void Start() {
        batteryLevel = 1;
        flashLight = gameObject.GetComponent<Light>();
        if (lightSliderObject == null) Debug.Log("lightSliderObject == null");
        else lightSlider = lightSliderObject.GetComponent<Slider>();
        sliderFill = sliderFillObject.GetComponent<Image>();
        flashLightEnabled = true;
        //set the slider color
        if (flashLightEnabled) {
            //set the color of the UI light slider to grey
            sliderFill.color = sliderActiveColor;
        }
        else if (!flashLightEnabled) {
            sliderFill.color = sliderInactiveColor;
        }
    }

    // Update is called once per frame
    void Update() {
        //if the flashlight is active
        if (flashLightEnabled) {
            //update the battery charge level
            if (batteryLevel > 0) {
                batteryLevel -= (Time.deltaTime / batteryDuration);
                flashLight.intensity = 3 * batteryLevel;
            }
        }
        //update the slider value
        if (lightSlider != null) lightSlider.value = batteryLevel;
        //Toggle the flashlight active
        if (Input.GetButtonDown("Activate Flashlight")) {
            //set the slider color
            if (flashLightEnabled) {
                //set the color of the UI light slider to grey
                sliderFill.color = sliderInactiveColor;
                flashLightEnabled = false;
            }
            else if (!flashLightEnabled) {
                sliderFill.color = sliderActiveColor;
                flashLightEnabled = true;
            }
        }
    }

    //adds 0.2 to the charge.
    public void ConsumeBattery() {
        Debug.Log("consume battery");
        if (batteryLevel + 0.2f > 1) batteryLevel = 1;
        else batteryLevel += 0.2f;
    }
}
