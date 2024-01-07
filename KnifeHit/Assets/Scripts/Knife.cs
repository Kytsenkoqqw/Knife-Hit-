using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    [SerializeField] private float _speedKnife;
    private Rigidbody2D _rb;
    private bool _isStuck;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Клавиша нажата");
            Debug.Log(_speedKnife);
            MoveKnife();
        }
    }

    private void MoveKnife()
    {
        _rb.velocity = new Vector2(0, _speedKnife * Time.deltaTime);
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
}
