﻿using UnityEngine;

public class MovingSphere : MonoBehaviour {
    [SerializeField, Range(0f, 100f)]
	 float maxAcceleration = 10f;
     float maxSpeed = 10f;
	void Update () {
        
		Vector2 playerInput;
        Vector3 velocity;
        /*
        Get Input axis for movement
        */
		playerInput.x = Input.GetAxis("Horizontal");
		playerInput.y = Input.GetAxis("Vertical");
       // playerInput.Normalize();
        //playerInput= Vector2.ClampMagnitude(playerInput, 1f);
        
		Vector3 desiredVelocity = 
        new Vector3 (playerInput.x, 0f, playerInput.y);
        float maxSpeedChange = maxAcceleration * Time.deltaTime;
        velocity.x =
			Mathf.MoveTowards(velocity.x, desiredVelocity.x, maxSpeedChange);
		velocity.z =
			Mathf.MoveTowards(velocity.z, desiredVelocity.z, maxSpeedChange);

	}
}