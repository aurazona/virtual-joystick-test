using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickReader : MonoBehaviour
{
    public float MovementVectorX; //stores the X value of the movement vector for easier reading
    public float MovementVectorY; //stores the Y value of the movement vector for easier reading
    public Vector2 JoystickMovementVector; //stores the full movement vector from the joystick
    public bool JoystickUsage; //stores whether the joystick is being used or not
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        JoystickMovementVector = InnerJoystickScript.movementVector;
        MovementVectorX = JoystickMovementVector.x;
        MovementVectorY = JoystickMovementVector.y;
        JoystickUsage = InnerJoystickScript.JoystickUsed;
    }
}
