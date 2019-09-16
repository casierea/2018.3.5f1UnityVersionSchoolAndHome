
using System;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class TransformController : MonoBehaviour
{
    public FloatData speed;

    public void Update()
    {
        var speedVector = new Vector3(speed.value, 0, 0) * Time.deltaTime;
            transform.Translate(speedVector);
        }
//should change this to a function about speed
}