using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BelieveMenController : MonoBehaviour {
    private bool canMove;
    private bool foundPlayer;
    private int unitCounter;
    private Vector2 randomVec;
    private Vector3 randomXZ;
    public GameObject player;
    public float idleSpeed;
    public float walkSpeed;
    public float detectionRange;
	// Use this for initialization
	void Start () {
        canMove = false;
        unitCounter = 1;
    }
	
	// Update is called once per frame
	void Update () {
        if (foundPlayer)
        {
            if ((player.transform.position - this.transform.position).sqrMagnitude < detectionRange * detectionRange)
            {
                transform.position = Vector3.MoveTowards(transform.position, player.transform.position, walkSpeed * Time.deltaTime);
            }
            else
            {
                foundPlayer = false;
            }
        }
        if (!canMove)
        {
            if ((player.transform.position - this.transform.position).sqrMagnitude < detectionRange * detectionRange)
            {
                foundPlayer = true;
            }
            else
            {
                randomVec = Random.insideUnitCircle.normalized;
                randomXZ = new Vector3(randomVec.x, 0f, randomVec.y);

                Vector3 start = Vector3.zero;
                if (!Physics.Raycast(transform.position, randomXZ, 10))
                {
                    canMove = true;
                }
            }
        }
        else if (canMove)
        {
            
            if (unitCounter < 20)
            {
                transform.position = transform.position + (idleSpeed *randomXZ);
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
