using UnityEngine;
using Cinemachine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class inGame_Buttons_script : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public CinemachineVirtualCamera vncam1;
   public CinemachineVirtualCamera vocam1;


   public  GameObject   soundSlider;
   public GameObject    AreUsure;
    public GameObject   QuitMainMenuButton;
   public GameObject    QuitDesktop;
   
    public  bool istimenew = true;

    private void awake()
    {
        
    }

    private void Start()
    {


        soundSlider.SetActive(false);

        
        AreUsure.SetActive(false);


    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
            {
                istimenew = !istimenew;

                if(istimenew)
                    {
                        vncam1.Priority = 20;
                        vocam1.Priority = 10;
                        

                    }
                else
                    {
                        vncam1.Priority = 10;
                        vocam1.Priority = 20;   
                    }
            }
       
    }

    public void OnPointerEnter(PointerEventData eventData)
    {

    }

    public void OnPointerExit(PointerEventData eventData)
    {

    }

    public  void RestartButtonClicked()
        {
            SceneManager.LoadScene(1);
        }
    public void RestartButtonZoom()
        {

            soundSlider.SetActive(false);

            Debug.Log("Restart'e yaklaşıldı");

           
        }
    public void RestartButtonUnZoom()
    {
        Debug.Log("Restartden çıkıldı");

    }

    public  void   CreditsButtonUnZoom()
        {

        }

    public void OptionsButtonClicked()
    {
        soundSlider.SetActive(!soundSlider.activeSelf);
    }

    public  void    OptionsButtonZoom()
        {
            AreUsure.SetActive(false);
        }
    public  void    OptionsButtonUnZoom()
        {
        }
    public  void    QuitButtonClicked()
        {
            AreUsure.SetActive(!AreUsure.activeSelf);

        }
    public void QuitButtonZoom()
        {
            soundSlider.SetActive(false);
        }  
    public void QuitMainMenuButtonClicked()
        {
            SceneManager.LoadScene(0);
        }
            public void QuitDektopClicked()
        {
                    Application.Quit();

        #if UNITY_EDITOR
                // Editörde çalışırken oyun modundan çık
                UnityEditor.EditorApplication.isPlaying = false;
        #endif
        }

}
