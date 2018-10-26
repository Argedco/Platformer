﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //designer variables
    public float speed = 10;
    public Rigidbody2D physicsBody;
    public string horizontalAxis = "Horizontal";
    public Animator PlayerAnimator;
    public SpriteRenderer PlayerSprite;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //Get Axis Input from Unity
        float leftRight = Input.GetAxis(horizontalAxis);

        //Create direction vector from axis input
        Vector2 direction = new Vector2(leftRight, 0);

        //Make direction vector length 1
        direction = direction.normalized;

        //Calculate Velocity
        Vector2 velocity = direction * speed;

        velocity.y = physicsBody.velocity.y;

        //give the velocity to our rigid body
        physicsBody.velocity = velocity;

        //Tell the animator our speed
        PlayerAnimator.SetFloat("WalkSpeed", Mathf.Abs(velocity.x));

        //Flip our sprite if we're moving backward
        if (velocity.x < 0)
        {
            PlayerSprite.flipX = true;
        }
        else
        {
            PlayerSprite.flipX = false;
        }
            
    
    }


}
