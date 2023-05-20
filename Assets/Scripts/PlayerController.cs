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
        float _input_X = 0f;
        float _input_Y = 0f;

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            _input_X -= 1;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            _input_X += 1;
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            _input_Y -= 1;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            _input_Y += 1;
        }
        
        Vector3 movement = new Vector3(_input_Y * playerSpeed * Time.deltaTime, 0, _input_X * playerSpeed * Time.deltaTime);
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
