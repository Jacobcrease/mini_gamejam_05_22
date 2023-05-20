using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float playerSpeed = 1.0f;
    [SerializeField] float rotSpeed = 1.0f;
    private CharacterController characterController;

    private Rigidbody rb;

    public void onMove (Vector2 moveVec)
    {
    }
    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 _actualSpeed;
        float _input_X = 0f;
        float _input_Y = 0f;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _input_X -= 1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _input_X += 1;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _input_Y += 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            _input_Y -= 1;
        }
        _actualSpeed = new Vector2 (_input_X * Time.deltaTime * playerSpeed, _input_Y * Time.deltaTime * playerSpeed);
        Vector3 movement = new Vector3(_input_X * playerSpeed * Time.deltaTime, 0, _input_Y * playerSpeed * Time.deltaTime);
        movement = transform.TransformDirection(movement);

        Debug.Log(movement);
        characterController.Move(movement);
      //  transform.position = new Vector3 (transform.position.x + _actualSpeed.x , 0f, transform.position.y + _actualSpeed.y);
    }
}
