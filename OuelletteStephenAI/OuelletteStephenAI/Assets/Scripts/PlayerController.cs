using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Paddle _paddle;
	
	void Update () {
        float velocity = Input.GetAxis("Vertical");
        _paddle.Move(velocity);
	}


}
