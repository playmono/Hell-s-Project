using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeEffect : MonoBehaviour
{
    // vars
    public bool shakeOn = true;
    public float horizontalShakeAmplitude;
    public float verticarlShakeAmplitude;

    // sprite original position
    private Vector2 originPosition;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        // if shake is enabled
        if (shakeOn)
        {
            originPosition = this.transform.position;
            transform.Find("Sprite").transform.position = originPosition + new Vector2(Mathf.Sin(Time.time) * horizontalShakeAmplitude, Mathf.Sin(Time.time * 2) * verticarlShakeAmplitude);
        }
    }

    

}
