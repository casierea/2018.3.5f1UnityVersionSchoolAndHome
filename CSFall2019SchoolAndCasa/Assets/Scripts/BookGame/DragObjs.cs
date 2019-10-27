using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class DragObjs : MonoBehaviour
{
    public bool draggy = false;
    public bool collisionOn = false;
    private Vector3 position;
    
   
    public void startDrag()
    {
        position = gameObject.transform.position;
        draggy = true;
    }

    public void drag()
    {
        transform.position = Input.mousePosition;
    }

    public void drop()
    {
        if (!collisionOn)
        {
            gameObject.transform.position = position;
        }

        draggy = false;
    }
}
