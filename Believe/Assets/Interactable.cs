using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour {

    GameObject uiText;
    GameObject uiTextPrefab;
    GameObject canvas;
    // Use this for initialization
    void Start() {
        canvas = GameObject.Find("Canvas");
        uiText = canvas.transform.Find("InteractableText").gameObject;
        uiText.SetActive(false);
    }

    // Update is called once per frame
    void Update() {

    }
    private void OnTriggerEnter(Collider other) {
        uiText.SetActive(true);
    }
    void OnTriggerStay(Collider other) {
        uiText.SetActive(true);
        if (Input.GetButtonDown("Interact")) {
            if (other.gameObject.name =="Player" && gameObject.tag == "Weapon") {
                gameObject.transform.parent = other.gameObject.transform;
                this.transform.localPosition = new Vector3(0, 0, 1.2f);
                this.transform.localRotation = Quaternion.Euler(90, 0, 0);
            }
        }
    }
    private void OnTriggerExit(Collider other) {
        uiText.SetActive(false);
    }
}
