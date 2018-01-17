using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongBall : MonoBehaviour {

    public Rigidbody rb;
    public float speed = 1000.0f;
    public Vector3 orientation;

    void Start(){
        rb.AddForce(orientation.normalized * speed);    
    }

    void OnCollisionEnter(Collision other){
        Debug.Log("Collided");
        rb.velocity = Vector3.zero;
        var paddle = other.gameObject.GetComponent<Paddle>();
        if (paddle != null){
            orientation = paddle.Reflect(orientation);
            rb.AddForce(orientation.normalized * speed);
        }
    }

}
