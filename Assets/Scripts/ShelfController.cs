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

        if (other.gameObject.CompareTag("M"))
            Create(1);

        if (other.gameObject.CompareTag("N"))
            Create(2);

        if (other.gameObject.CompareTag("Z"))
            Create(3);
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
        yaratýlan = Instantiate(yaþlýPrefab[index], location.position, Quaternion.Euler(0,90,0));
    }
}
