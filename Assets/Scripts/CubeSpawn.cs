using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CubeSpawn : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    private Rigidbody _rb;
    private float _torqueValue = 5f;

    private void Start()
    {
        StartCoroutine(SpawnWithDelay());
    }

    IEnumerator SpawnWithDelay()
    {
        SpawnObject();
        yield return new WaitForSeconds(1f);
        StartCoroutine(SpawnWithDelay());
    }

    void SpawnObject()
    {
        GameObject newObject = Instantiate(prefab, new Vector3(Random.Range(-15.5f, 15.5f), 28f, 12.5f), Quaternion.identity);
        newObject.GetComponent<Rigidbody>().AddTorque(_torqueValue, _torqueValue, _torqueValue);
    }
}
