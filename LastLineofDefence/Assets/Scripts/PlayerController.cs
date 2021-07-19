using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Components
    public Rigidbody playerRigidBody;
    private float _inputX;
    public float speed = 3f;
    private float _movementX;
    public int playerHealth = 30;
    
    void Start()
    {
       
    }

    private void Update()
    {
        _inputX = Input.GetAxis("Horizontal");
        _inputZ = Input.GetAxis("Vertical");
        playerRigidBody.transform.position = new Vector3(0, 1, 0);
        
    }
    void FixedUpdate()
    {
        
        _movementX = Input.GetAxis("Horizontal");
        Vector3 _movement = new Vector3(_movementX, 0, 0);
        playerRigidBody.transform.Rotate(Vector3.up * _inputX * (100f * Time.deltaTime));
        



    }
}
