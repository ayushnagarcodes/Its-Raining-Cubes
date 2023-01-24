using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class CubeBehavior : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("LoseArea") || collision.gameObject.CompareTag("Floor"))
        {
            Destroy(gameObject);
        }
    }
}
