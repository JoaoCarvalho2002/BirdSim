using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour
{
   [SerializeField] private GameObject Mainmenu;
   [SerializeField] private GameObject Showlevels;
   [SerializeField] private GameObject logo;

    [SerializeField] private GameObject pauseMenu;
    public void StartGame()
    {
        Mainmenu.SetActive(false);
        Showlevels.SetActive(true);

    }
    public void Update()
    {

        if(Input.GetKeyDown(KeyCode.Escape)) {
            if (pauseMenu.activeInHierarchy) {
                SettingsLeave();
            }
            else{
                Settings();
            }
            
        }
    }
    public void backmainmenu()
    {
        Mainmenu.SetActive(true);
        Showlevels.SetActive(false);

    }
    public void Settings()
    {
        
        pauseMenu.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }
    public void SettingsLeave()
    {
        
        pauseMenu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene(0);

    }
    public void LoadLevel1()
    {
        SceneManager.LoadScene(1);
        Showlevels.SetActive(false);
        logo.SetActive(false);
    }
    public void LoadLevel2()
    {
        SceneManager.LoadScene(2);
        Showlevels.SetActive(false);
        logo.SetActive(false);
    }
    public void LoadLevel3()
    {
        SceneManager.LoadScene(3);
        Showlevels.SetActive(false);
        logo.SetActive(false);
    }
}

