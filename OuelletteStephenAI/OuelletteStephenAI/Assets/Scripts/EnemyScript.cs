using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    public Vector3 forward;
    public Vector3 forwardLeft;
    public Vector3 otherPosition;
    public Transform Player;
    public float threshold = 0.8f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        if (Player){
            forward = transform.forward;
            forwardLeft = ;
            otherPosition = transform.position - Player.position;
            
            Debug.DrawRay(transform.position, forward * 10, Color.green);
            Debug.DrawRay(transform.position, forwardLeft , Color.red);
            if (Vector3.Dot(forward, otherPosition) > threshold)
            {
                Debug.Log("Can't See the Player");
            }
            else {
                Debug.Log("I can See the Player");
            }

        }
	}
}
