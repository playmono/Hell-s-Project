using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementInFall : MonoBehaviour
{

    // MOVEMENT
    public float playerSpeed = 4.0f;
    private bool enableMovement = false;

    private bool facingRight = true;


    // Start is called before the first frame update
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (enableMovement)
        {
            Move();
        }
    }

    //Habilitar o desabilitar movimiento
    public void EnableMove(bool newState)
    {
        enableMovement = newState;
    }

    //Mover el personaje
    private void Move()
    {
        
        float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, 0f);
        this.GetComponent<Rigidbody2D>().velocity = movement * playerSpeed;

        //Girar sprite hacia donde se este moviendo
        if (!facingRight && moveHorizontal > 0f)
            Flip();
        else if (facingRight && moveHorizontal < 0f)
            Flip();

        //Limita el movimiento dentro de la camara principal
        var pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp(pos.x, 0.1f, 0.9f);
        pos.y = Mathf.Clamp(pos.y, 0.1f, 0.9f);
        transform.position = Camera.main.ViewportToWorldPoint(pos);

    }

    //Girar el sprite
    private void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x = -theScale.x;
        transform.localScale = theScale;
    }
}
