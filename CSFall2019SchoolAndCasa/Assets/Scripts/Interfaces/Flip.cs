using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    private Vector3 orientation;

    private void Flipper (float direction)
    {
        orientation.y = direction;
        transform.rotation = Quaternion.Euler(orientation);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow)) Flipper(direction: 180);
        if(Input.GetKeyDown(KeyCode.RightArrow)) Flipper(direction: 0);
    }
}

