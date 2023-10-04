using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float speed;
    private Vector3 _moveDirection;
    [SerializeField] private float jumpForce;
    private Rigidbody rb;


    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {

        InputManager.Init(this);
        InputManager.SetGameControls();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * Time.deltaTime * _moveDirection;
        CheckGround();

    }

    public void SetMovementDirection(Vector3 currentDirection)
    {
        _moveDirection = currentDirection;
    }
    public void Jump()
    {
        Debug.Log("Jump called");
        if (isGrounded)
        {
            Debug.Log("i jumped");
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private void CheckGround()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, GetComponent<Collider>().bounds.size.y);
        Debug.DrawRay(transform.position, Vector3.down * GetComponent<Collider>().bounds.size.y, Color.green, duration: 0, depthTest: false);
    }
}