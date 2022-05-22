using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float runSpeed = 3.4f;
    

    float horizontalMove = 0f;
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;   
    }

    void fixedUpdate()
    {
        CharacterMovement.Move(horizontalMove,false,false);
    }
}
