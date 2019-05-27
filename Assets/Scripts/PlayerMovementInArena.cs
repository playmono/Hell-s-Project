using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementInArena : MonoBehaviour
{
    public float currentSpeed = 5.0f;


    private void FixedUpdate()
    {
        this.Move();
    }

    private void Move()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
 
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        // @todo: We need to normalize but Normalize has strange behaviour
        //movement.Normalize();

        this.transform.Translate(movement * this.currentSpeed * Time.deltaTime, Space.World);
    }
}
