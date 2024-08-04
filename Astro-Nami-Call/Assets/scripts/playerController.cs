using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerController : MonoBehaviour
{
    PlayerInput playerInput;
    InputAction movementAction;
    
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        movementAction = playerInput.actions.FindAction("Movement");
    }

    
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        Vector2 direction = movementAction.ReadValue<Vector2>();
        transform.position += new Vector3(direction.x, 0, direction.y) * Time.deltaTime;
    }
}
