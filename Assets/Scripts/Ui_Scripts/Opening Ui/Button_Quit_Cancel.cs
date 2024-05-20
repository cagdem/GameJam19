using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Quit_Cancel : MonoBehaviour
{
    public  GameObject  AreUsure;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public  void Quit_Cancel_Clicked()
    {
        AreUsure.SetActive(false);
    }
}
