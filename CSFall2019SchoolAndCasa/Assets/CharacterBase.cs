using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterBase : ScriptableObject
{
    public float moveSpeed = 3;
    public float gravity = 9.81f;
    public float jumpSpeed = 75f;
    public CharacterController Controller { get; set; }
    protected Vector3 Location;
    protected Vector3 Orientation;



    public abstract void Move();

}
