using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyScript : MonoBehaviour {

    public Vector3 forward, otherPosition;
    public Transform Player, Target;
    public float threshold = -1.5f;
    public GameObject spotted,heard;
    public bool isSpotted = false, isHeard = false;


    void Update () {
	if (Player){
        	forward = transform.forward;
            otherPosition = transform.position - Player.position;
            Vector3 targetDir = Player.position - transform.position;
            
            Quaternion angleOffsetLeft = Quaternion.AngleAxis(-45, new Vector3(0, 1, 0));
            Vector3 angleLeft = angleOffsetLeft * forward;
            Quaternion angleOffsetright = Quaternion.AngleAxis(45, new Vector3(0, 1, 0));
            Vector3 angleRight = angleOffsetright * forward;
            Debug.DrawRay(transform.position, angleRight * 5f, Color.red);
            Debug.DrawRay(transform.position,  angleLeft * 5f, Color.red);
           

            float angle = Vector3.Angle(targetDir, forward);
            var dist = Vector3.Distance(Player.position, transform.position);

            if (angle < 45.0f && dist < 5.0f){
                spotted.SetActive(true);
                isSpotted = true;
                ReloadLevel();
            }
            else {
                spotted.SetActive(false);
                isSpotted = false;
            }
            if (!isSpotted && angle < 360 && dist < 8.0f) {
                heard.SetActive(true);
                isHeard = true;
                SmoothLookAt(-otherPosition);
            }
            else
            {
                heard.SetActive(false);
                isHeard = false;
            }
        }
}
    void SmoothLookAt(Vector3 newDirection)
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(newDirection), Time.deltaTime);
    }

    void ReloadLevel() {
        if (isSpotted) {
            SceneManager.LoadScene(0);
        }
    }
}
