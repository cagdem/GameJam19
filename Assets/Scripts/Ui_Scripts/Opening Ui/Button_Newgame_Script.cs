using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class Button_Newgame_Script : MonoBehaviour
{
    // Start is called before the first frame update

    void    Awake()
        {

        }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NewgameButtonClicked()
        {
            SceneManager.LoadScene(1);
        } 
}
