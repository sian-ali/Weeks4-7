using UnityEngine;
using UnityEngine.InputSystem;

public class Rotater : MonoBehaviour
{
    public float moveSpeed;
    public float rotationSpeed;
    public float speed = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //right arrow key
        bool isRightHeld = Keyboard.current.rightArrowKey.isPressed;
        if (isRightHeld)
        {
            //rotate
            transform.eulerAngles -= transform.forward * rotationSpeed * Time.deltaTime;

            //moves
            Vector3 newPosition = transform.position;
            newPosition.x += speed;
            transform.position = newPosition;
            
        }
        //left arrow key
        bool isLeftHeld = Keyboard.current.leftArrowKey.isPressed;
        if (isLeftHeld)
        {
            //rotate
            transform.eulerAngles += transform.forward * rotationSpeed * Time.deltaTime;

            //move
            Vector3 newPosition = transform.position;
            newPosition.x += -speed;
            transform.position = newPosition;
        }
        //rotation min and max
        //transform min and max values (cap movement left screen)
    }
}
