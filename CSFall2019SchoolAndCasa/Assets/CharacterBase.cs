<<<<<<< HEAD
﻿using System.Collections;
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
=======
﻿using UnityEngine;

public abstract class CharacterBase : ScriptableObject
{
    //public Transform CharacterTransform { get; set; }
    public CharacterController Controller { get; set; }
    
    protected Vector3 Location;
    protected Vector3 Orientation;
    public float speed = 10f;
    public float orientSpeed = 3f;
    
    public abstract void Move();
}
>>>>>>> master
