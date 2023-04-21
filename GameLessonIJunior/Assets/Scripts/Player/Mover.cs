using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>(); 
    }

    private void Update()
    {
        //transform.position += Vector3.forward * _speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
            Move(Vector3.forward);
        else if (Input.GetKey(KeyCode.S))
            Move(Vector3.back);
        else if (Input.GetKey(KeyCode.A))
            Move(Vector3.left);
        else if (Input.GetKey(KeyCode.D))
            Move(Vector3.right);
    }

    private void Move(Vector3 direction)
    {   
        _rigidbody.AddForce(direction * _speed);
    }

}
