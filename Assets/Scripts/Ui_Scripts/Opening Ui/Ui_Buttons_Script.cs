using UnityEngine;
using Cinemachine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ButtonAnimationController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
   public CinemachineVirtualCamera vncam1;
   public CinemachineVirtualCamera vncam2;
   public CinemachineVirtualCamera vncam3;
   public CinemachineVirtualCamera vncam4;
   public CinemachineVirtualCamera vocam1;
   public CinemachineVirtualCamera vocam2;
   public CinemachineVirtualCamera vocam3;
   public CinemachineVirtualCamera vocam4;

   public  GameObject Button_NewGame;
   public  GameObject  soundSlider;
   public GameObject Credits_Image;
   public GameObject AreUsure;
   
    public  bool istimenew = true;

    private void awake()
    {
        
    }

    private void Start()
    {
        Time.timeScale = 1;


        soundSlider.SetActive(false);

        Credits_Image.SetActive(false);

        Button_NewGame.SetActive(false);
        
        AreUsure.SetActive(false);


    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
            {
                istimenew = !istimenew;

                vocam2.Priority = 1;
                vocam3.Priority = 1;
                vocam4.Priority = 1;
                vncam2.Priority = 1;
                vncam3.Priority = 1;
                vncam4.Priority = 1;


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

    public  void PlayButtonClicked()
        {
            Button_NewGame.SetActive(!Button_NewGame.activeSelf);
        }
    public void PlayButtonZoom()
        {
            Credits_Image.SetActive(false);

            soundSlider.SetActive(false);

            Debug.Log("Play'e yaklaşıldı");

            if (istimenew)
                {
                    vncam2.Priority = vncam1.Priority+1;

                    vocam2.Priority = 1;
                    vocam3.Priority = 1;
                    vocam4.Priority = 1;

                    vncam3.Priority = 1;
                    vncam4.Priority = 1;
                }
            else
                {
                    vocam2.Priority = vocam1.Priority+1; 

                    vocam3.Priority = 1;
                    vocam4.Priority = 1;
                    vncam2.Priority = 1;
                    vncam3.Priority = 1;
                    vncam4.Priority = 1;
                };    
        }
    public void PlayButtonUnZoom()
    {
        Debug.Log("Playden çıkıldı");

        if(!Button_NewGame.activeSelf)
            {
                if (istimenew)
                    {
                        vocam2.Priority = 1;
                        vocam3.Priority = 1;
                        vocam4.Priority = 1;
                        vncam2.Priority = 1;
                        vncam3.Priority = 1;
                        vncam4.Priority = 1;
                    }
                else
                    {
                        vocam2.Priority = 1;
                        vocam3.Priority = 1;
                        vocam4.Priority = 1;
                        vncam2.Priority = 1;
                        vncam3.Priority = 1;
                        vncam4.Priority = 1;   
                    };
            }
    }
    public  void   CreditsButtonZoom()
        {
            soundSlider.SetActive(false);
            Button_NewGame.SetActive(false);

            Debug.Log("Creditsa yaklaşıldı");

            if (istimenew)
                {
                    vncam3.Priority = vncam1.Priority+1;

                    vocam2.Priority = 1;
                    vocam3.Priority = 1;
                    vocam4.Priority = 1;
                    vncam2.Priority = 1;

                    vncam4.Priority = 1;
                }
            else        
                {   
                    vocam3.Priority = vocam1.Priority+1;

                    vocam2.Priority = 1;

                    vocam4.Priority = 1;
                    vncam2.Priority = 1;
                    vncam3.Priority = 1;
                    vncam4.Priority = 1;   
                }; 
        }
    public  void    CreditsButtonClicked()
        {
            Credits_Image.SetActive(!Credits_Image.activeSelf);
        } 
    public  void   CreditsButtonUnZoom()
        {

            Debug.Log("Creditsten çıkıldı");
            if(!Credits_Image.activeSelf)
                {
                    if (istimenew)
                        {
                            vocam2.Priority = 1;
                            vocam3.Priority = 1;
                            vocam4.Priority = 1;
                            vncam2.Priority = 1;
                            vncam3.Priority = 1;
                            vncam4.Priority = 1;
                        }
                    else        
                        {       
                            vocam2.Priority = 1;
                            vocam3.Priority = 1;
                            vocam4.Priority = 1;
                            vncam2.Priority = 1;
                            vncam3.Priority = 1;
                            vncam4.Priority = 1;
                        };
                }
        }

    public void OptionsButtonClicked()
    {
        soundSlider.SetActive(!soundSlider.activeSelf);
    }

    public  void    OptionsButtonZoom()
        {
            Credits_Image.SetActive(false);

            Button_NewGame.SetActive(false);

            Debug.Log("Optiona yaklaşıldı");

            if (istimenew)
                {
                    vncam4.Priority = vncam1.Priority+1;

                    vocam2.Priority = 1;
                    vocam3.Priority = 1;
                    vocam4.Priority = 1;
                    vncam2.Priority = 1;
                    vncam3.Priority = 1;

                }
            else        
                {       
                    vocam4.Priority = vocam1.Priority+1;

                    vocam2.Priority = 1;
                    vocam3.Priority = 1;

                    vncam2.Priority = 1;
                    vncam3.Priority = 1;
                    vncam4.Priority = 1;
     
                }

        }
    public  void    OptionsButtonUnZoom()
        {
            Debug.Log("Optiontan çıkıldı");

            if(!soundSlider.activeSelf)
                {
                if (istimenew)
                    {
                        vocam2.Priority = 1;
                        vocam3.Priority = 1;
                        vocam4.Priority = 1;
                        vncam2.Priority = 1;
                        vncam3.Priority = 1;
                        vncam4.Priority = 1;;
                    }
                else        
                    {       
                        vocam2.Priority = 1;
                        vocam3.Priority = 1;
                        vocam4.Priority = 1;
                        vncam2.Priority = 1;
                        vncam3.Priority = 1;
                        vncam4.Priority = 1;;       
                    };
                }
        }
    public  void    QuitButtonClicked()
        {
            AreUsure.SetActive(!AreUsure.activeSelf);
            
            Credits_Image.SetActive(false);

            Button_NewGame.SetActive(false);
        } 
}
