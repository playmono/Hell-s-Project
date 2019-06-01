using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestructionOffScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Disable the behaviour when it becomes invisible...
    void OnBecameInvisible()
    {
        this.enabled = false;
        Destroy(this.gameObject);
    }

    // ...and enable it again when it becomes visible.
    void OnBecameVisible()
    {
        this.enabled = true;
    }
}
