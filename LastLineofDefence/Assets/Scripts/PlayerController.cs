using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidBody;
    private float _inputX;
    private float _inputZ;
    public float speed = 3f;
    private float _movementX;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationY;
    }

    private void Update()
    {
        _inputX = Input.GetAxis("Horizontal");
        _inputZ = Input.GetAxis("Vertical");
    }
    void FixedUpdate()
    {
        playerRigidBody.transform.position = new Vector3(0, 1, 0);
        _movementX = Input.GetAxis("Horizontal");
        Vector3 _movement = new Vector3(_movementX, 0, 0);
        playerRigidBody.transform.Rotate(Vector3.up * _inputX * (100f * Time.deltaTime));
        



    }
}
