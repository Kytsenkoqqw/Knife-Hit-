using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class Knife : MonoBehaviour
{
    [SerializeField] private float _speedKnife;
    [SerializeField] private float _throwForce = 10;
    private Rigidbody2D _rb;
    private bool _isStuck;
    private bool _isFly;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 throwDirection = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position).normalized;

            // Задаем силу броска
           
            _rb.velocity = throwDirection * _throwForce;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Log") && !_isStuck)
        {
            transform.parent = collision.transform;
            _rb.velocity = Vector2.zero;
            _isStuck = true;
        }
    }

    private void OffMove()
    {
        if (_isStuck)
        {
            _rb.velocity = Vector2.zero;
        }
    }
}
