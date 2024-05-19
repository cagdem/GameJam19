using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfController : MonoBehaviour
{
    public Transform location;
    public GameObject[] ya�l�Prefab;
    private GameObject yarat�lan;

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
        Destroy(yarat�lan); 
    }

    private void Create(int index)
    {
        if (yarat�lan != null)
        {
            Destroy(yarat�lan);
        }
        yarat�lan = Instantiate(ya�l�Prefab[index], location.position, Quaternion.identity);
    }
}
