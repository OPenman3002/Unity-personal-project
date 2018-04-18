﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private Rigidbody2D myRigidBody;


    [SerializeField]
    private float movementSpeed;

    // Use this for initialization
    void Start ()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        float horizontal = Input.GetAxis("Horizontal");

        HandleMovement(horizontal);
	}
    private void HandleMovement(float horizontal)
    {
        myRigidBody.velocity = new Vector2(horizontal * movementSpeed , myRigidBody.velocity.y);

    }
}
