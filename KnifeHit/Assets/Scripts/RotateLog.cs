using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLog : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 5f; // Скорость вращения

    void Update()
    {
        transform.Rotate(0, _rotationSpeed * Time.deltaTime,0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Knife"))
        {
            ;
        }
    }
}
