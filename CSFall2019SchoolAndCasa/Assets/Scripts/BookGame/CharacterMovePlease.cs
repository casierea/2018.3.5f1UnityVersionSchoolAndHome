using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMovePlease : MonoBehaviour
{
    private CharacterController Controller;

    private float Gravity = 9.81f;
    public float MoveSpeed = 5.0f;
    private Vector3 rot;


    private Vector3 position;
    //private Vector3 rotation;

    void Start()
    {
        Controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (Controller.isGrounded)
        {
            position.Set(MoveSpeed * Input.GetAxis("Horizontal"), 0, MoveSpeed * Input.GetAxis("Vertical"));
            // rotation.Set(0, Input.GetAxis("Vertical"), 0);
            // transform.Rotate(rotation);
            position = transform.TransformDirection(position);
            //print(position);

        
        }

        position.y -= Gravity * Time.deltaTime;
        Controller.Move(position * Time.deltaTime);

    }
}