using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float playerSpeed = 1.0f;
    [SerializeField] float rotSpeed = 1.0f;
    private CharacterController characterController;

    public Vector3 getInput ()
    {
        float _inputLeftRight = 0f;
        float _inputForwardBackwards = 0f;

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            _inputLeftRight -= 1;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            _inputLeftRight += 1;
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            _inputForwardBackwards -= 1;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            _inputForwardBackwards += 1;
        }
        
        Vector3 movement = new Vector3(_inputForwardBackwards * playerSpeed * Time.deltaTime, 0, _inputLeftRight * playerSpeed * Time.deltaTime);
        return movement;
    }
    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }
    
    void Update()
    {
        Vector3 movement = getInput();

        characterController.Move(movement);
    }
}
