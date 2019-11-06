using System.Collections;
using UnityEngine;
using UnityEngine.Events;
 


//Anthony'script For learning how to draggable Object for flashlight

public class DragObj3D: MonoBehaviour
{
    private Vector3 offsetPosition;
    private Vector3 newPosition;
    private Camera cam;

    public bool CanDrag { get; set; }
    public UnityEvent OnDrag;
    public UnityEvent OnUp;
    public bool Draggable { get; set; }

    private void Start()
    {
        cam = Camera.main;
        Draggable = true;
    }

    public IEnumerator OnMouseDown()
    {
        print("dragging");
        OnDrag.Invoke();
        offsetPosition = transform.position - cam.ScreenToWorldPoint(Input.mousePosition);
        print(offsetPosition);
       // yield return new WaitForFixedUpdate();
        CanDrag = true;
        while (CanDrag)
        {
           // yield return new WaitForFixedUpdate();
           newPosition = cam.ScreenToWorldPoint(Input.mousePosition) + offsetPosition;
           print(newPosition);
            transform.position = newPosition;
            yield return null;

        }
    }

    private void OnMouseUp()
    {
        CanDrag = false;
        if (Draggable)
        {
            OnUp.Invoke();
        }
    }
}