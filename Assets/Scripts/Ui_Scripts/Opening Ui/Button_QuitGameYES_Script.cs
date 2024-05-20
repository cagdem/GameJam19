using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_QuitGame_Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public  void Quit_YesClicked()
    {
        Application.Quit();

        #if UNITY_EDITOR
                // Editörde çalışırken oyun modundan çık
                UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
