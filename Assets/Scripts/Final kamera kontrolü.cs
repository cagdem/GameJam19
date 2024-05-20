using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Finalkamerakontrolü : MonoBehaviour
{
    public CinemachineVirtualCamera v1;
    public CinemachineVirtualCamera v2;
    public CinemachineVirtualCamera v3;
    public CinemachineVirtualCamera v4;
    public CinemachineVirtualCamera v5;
    private float timer1 = 0;
    private float timer2 = 0;
    private float timer3 = 0;
    private float timer4 = 0;
    private bool timerReached1 = true;
    private bool timerReached2 = true;
    private bool timerReached3 = true;
    private bool timerReached4 = true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame


void Update()
    {
        if (!timerReached1)
            timer1 += Time.deltaTime;

        {
            if (!timerReached1 && (timer1 > 5)&&(timer1<7))
            {
                Debug.Log("1. geçiş");
                v2.Priority = v1.Priority+1;

                //Set to false so that We don't run this again
                timerReached2 = false;
            }
        }
                if (!timerReached2)
            timer2 += Time.deltaTime;

        if (!timerReached2 && (timer2 > 5)&&(timer2<7))
        {
            Debug.Log("2. geçiş");
            v3.Priority = v2.Priority+1;

            //Set to false so that We don't run this again
            timerReached3 = false;
        }
        if (!timerReached3)
            {
                timer3 += Time.deltaTime;
            }

        if (!timerReached3 && (timer3 > 5)&&(timer3<7))
        {
            Debug.Log("3. geçiş");
            v4.Priority = v3.Priority+1;

            //Set to false so that We don't run this again
        }
        if (!timerReached4)
            {
                timer3 += Time.deltaTime;
            }

        if (!timerReached4 && (timer4 > 5)&&(timer4<7))
        {
            Debug.Log("4. geçiş");
            v5.Priority = v4.Priority+1;

            //Set to false so that We don't run this again
        }

    }
    void OnTriggerEnter(Collider other)
        {
            timerReached1 = false;
        }
}