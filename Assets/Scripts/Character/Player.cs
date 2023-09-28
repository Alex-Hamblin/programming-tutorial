using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    private Vector2 _moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        InputManager.Init(myPlayer:this);
        InputManager.SetGameControls();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3) (_moveDirection * speed * Time.deltaTime);
    }
    public void SetMovementDirection(Vector3 currentDirection)
    {
        _moveDirection = currentDirection;

    }
}
