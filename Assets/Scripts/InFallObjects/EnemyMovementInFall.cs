using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementInFall : MonoBehaviour
{
    // MOVEMENT
    public float enemySpeed = 4.0f;
    public bool enableMovement = true;
    public string movementType;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        if (enableMovement)
        {
            Move(movementType);
        }
    }

    public void Move(string selectedMovementType)
    {
        switch (selectedMovementType)
        {
            case "UpForward":
                MoveUpForward();
                break;
            default:
                Debug.LogError("Movement type: " + selectedMovementType + ", no existe");
                break;
        }
    }

    private void MoveUpForward()
    {
        Vector2 movement = new Vector2(0f, 1f);
        this.GetComponent<Rigidbody2D>().velocity = movement * enemySpeed;
    }
}
