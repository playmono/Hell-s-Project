﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementInFall : MonoBehaviour
{

    // MOVEMENT
    public float playerSpeed = 4.0f;
    private bool enableMovement = false;

    private Rigidbody2D rigidbody;

    // Start is called before the first frame update
    private void Start()
    {
        rigidbody = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Move();
    }

    //Habilitar o desabilitar movimiento
    public void EnableMove(bool newState)
    {
        enableMovement = newState;
    }

    //Mover el personaje
    private void Move()
    {
        if (enableMovement)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            //float moveVertical = Input.GetAxis("Vertical");

            Vector2 movement = new Vector2(moveHorizontal, 0f);
            rigidbody.velocity = movement * playerSpeed;

            //Limita el movimiento dentro de la camara principal
            var pos = Camera.main.WorldToViewportPoint(transform.position);
            pos.x = Mathf.Clamp(pos.x, 0.1f, 0.9f);
            pos.y = Mathf.Clamp(pos.y, 0.1f, 0.9f);
            transform.position = Camera.main.ViewportToWorldPoint(pos);
        }

    }
}
