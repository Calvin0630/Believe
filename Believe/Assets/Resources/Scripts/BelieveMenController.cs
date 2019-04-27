using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BelieveMenController : MonoBehaviour {
    private bool canMove;
    private int unitCounter;
    private Vector2 randomVec;
    private Vector3 randomXZ;
    public float speed;
	// Use this for initialization
	void Start () {
        canMove = false;
        unitCounter = 1;
    }
	
	// Update is called once per frame
	void Update () {
        if (!canMove)
        {
            randomVec = Random.insideUnitCircle.normalized;
            randomXZ = new Vector3(randomVec.x, 0f, randomVec.y);

            Vector3 start = Vector3.zero;
            if (!Physics.Raycast(transform.position, randomXZ, 10))
            {
                canMove = true;
            }
        }
        else if (canMove)
        {
            
            if (unitCounter < 20)
            {
                transform.position = transform.position + (speed *randomXZ);
                unitCounter++;
            }
            else
            {
                unitCounter = 1;
                canMove = false;
            }
        }
    }
}
