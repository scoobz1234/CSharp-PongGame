using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    public float moveSpeed = 10.0f;
    public float offset = 5.3f;
    float pos;
    public Vector3 normal;

    public void Start(){
        pos = transform.position.z;
    }

    public void Move(float velocity) {

        Vector3 position = transform.position;
        position.z = Mathf.Clamp(transform.position.z + (velocity * moveSpeed * Time.deltaTime),
            pos - offset, pos + offset);
        transform.position = position;

    }

    public Vector3 Reflect(Vector3 orientation) {
        normal.Normalize();
        float distance = -Vector3.Dot(normal, orientation);
        Vector3 reflectionOffset = normal * distance * 2;
        var reflect = orientation + reflectionOffset;

        return reflect;
    }
}
