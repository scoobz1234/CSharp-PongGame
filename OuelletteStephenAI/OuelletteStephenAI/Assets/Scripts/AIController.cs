using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour {

    public Paddle _paddle;
    public Transform _followTarget;
    public float offset = 5.3f;
    float pos;

    public void Start(){
        pos = transform.position.z;
    }

    void Update(){
        Vector3 position = transform.position;
        position.z = Mathf.Clamp(_followTarget.position.z, pos - offset, pos + offset);
  
        transform.position = position;
        
    }


}
