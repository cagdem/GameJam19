using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterGuesser : MonoBehaviour
{
    public string tag;
    
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(tag))
        {

        }
    }
}
