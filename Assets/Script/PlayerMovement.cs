using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform _groundCheck;
    [SerializeField] private SpriteRenderer _sr;
    public Sprite _srIdle;
    public Sprite _srSide;
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private int _jumpCount;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private int _jumpPower;
    [SerializeField] private bool grounded;
    [SerializeField] private LayerMask _layerMask;
    [SerializeField] private BoxCollider2D coll;
    [SerializeField] private AudioSource _jumpSFX;



    void Start()
    {

    }
    void Update()
    {
        float dirX = Input.GetAxis("Horizontal");
        print(dirX);
        _rb.velocity = new Vector2(dirX * _moveSpeed, _rb.velocity.y);
        if (dirX > 0)
        {  
            _sr.sprite = _srSide;
            _sr.flipX = false;
        }

        else if (dirX < 0)
        {
            _sr.sprite = _srSide;
            _sr.flipX = true;
        }
        else
            _sr.sprite = _srIdle;


        if (Input.GetKeyDown("space"))
        {
            if (isGrounded() == true)
            {
                _jumpSFX.Play();
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
