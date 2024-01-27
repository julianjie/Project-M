using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform _groundCheck;
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private int _jumpCount;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private int _jumpPower;
    [SerializeField] private bool grounded;
    [SerializeField] private LayerMask _layerMask;
    [SerializeField] private BoxCollider2D coll;

    void Start()
    {

    }
    void Update()
    {
        float dirX = Input.GetAxis("Horizontal");
        _rb.velocity = new Vector2(dirX * _moveSpeed, _rb.velocity.y);

        if (Input.GetKeyDown("space"))
        {
            if (isGrounded() == true)
            {
                _rb.velocity = new Vector3(0, _jumpPower, 0);
            }
        }


    }
    private bool isGrounded()
    {
        var col = Physics2D.OverlapCircle(_groundCheck.position, 0.1f, _layerMask);
        return col != null;
    }
}
