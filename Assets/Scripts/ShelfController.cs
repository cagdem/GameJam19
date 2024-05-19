using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfController : MonoBehaviour
{
    public Transform location;
    public GameObject[] yaþlýPrefab;
    private GameObject yaratýlan;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("A"))
            Create(0);

        if (other.gameObject.CompareTag("B"))
            Create(1);

        if (other.gameObject.CompareTag("C"))
            Create(2);
    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(yaratýlan); 
    }

    private void Create(int index)
    {
        if (yaratýlan != null)
        {
            Destroy(yaratýlan);
        }
        yaratýlan = Instantiate(yaþlýPrefab[index], location.position, Quaternion.identity);
    }
}
