using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerometerInput : MonoBehaviour {

    [Range(0.1f,1.5f)]public float motionSpeed;
    public float rangeLimit;


	// Update is called once per frame
	void Update () {
        transform.Translate(Input.acceleration.x * motionSpeed, 0 ,0);

        Vector2 clampedPostion = transform.position;

        clampedPostion.x = Mathf.Clamp(transform.position.x,-rangeLimit,rangeLimit);

        transform.position = clampedPostion;
        //Debug.Log(Input.acceleration.x * motionSpeed);
	}
}
