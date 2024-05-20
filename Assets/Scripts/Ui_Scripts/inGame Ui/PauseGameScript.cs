using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGameScript : MonoBehaviour
{
    public GameObject Pause_Screen;
    private bool timepaused=false;
    // Start is called before the first frame update
    void Start()
    {
        Pause_Screen.SetActive(false);
        Time.timeScale = 1;
        Cursor.visible=false;
    }

    // Update is called once per frame
    void Update()
    {
                    if(Cursor.lockState == CursorLockMode.Locked)
                {
                    Debug.Log("Mouse kilitli");
                }
            else
                {
                    Debug.Log("Mouse açık");
                }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible=!Cursor.visible;
            timepaused = !timepaused;
            Pause_Screen.SetActive(!Pause_Screen.activeSelf);
            if(timepaused)
                {
                    Time.timeScale = 0;
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible=true;
                }
            else 
                {
                    Time.timeScale = 1;
                    Cursor.lockState = CursorLockMode.Locked;
                    Cursor.visible=false;
                }

 
        }
    }
}
