using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockTrigger : MonoBehaviour
{

    [SerializeField] private GameObject _badBlock;
    private float _moveSpeed = 0.0f;
    private void OnTriggerEnter(Collider other)
    {
        //_badBlock.transform.position = Vector3.Lerp(_badBlock.transform.position, new Vector3(10.6f, 0.3f, -34.0f), 10.0f);
        DropBlock();
    }

    private void DropBlock()
    {
        //_badBlock.transform.position = Vector3.Lerp(_badBlock.transform.position, new Vector3(10.6f, 0.3f, -34.0f), 0.2f);
        _badBlock.GetComponent<Rigidbody>().useGravity = true;
    }
    
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }
}
