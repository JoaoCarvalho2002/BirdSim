using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour
{
   [SerializeField] private GameObject Mainmenu;
   [SerializeField] private GameObject Showlevels;
   [SerializeField] private GameObject logo;

   [SerializeField] private GameObject optionsMenu;

    [SerializeField] private GameObject pauseMenu;

    [SerializeField] private GameObject fichatecnica;

    public Resolutionscript functiongetting;

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
    public void OpenOptions()
    {
        Mainmenu.SetActive(false);
        optionsMenu.SetActive(true);

    }
    public void FichaTecnica()
    {
        Mainmenu.SetActive(false);
        fichatecnica.SetActive(true);

    }
    public void closeFichaTecnica()
    {
        fichatecnica.SetActive(false);
        Mainmenu.SetActive(true);

    }
    public void backmainmenu()
    {
        Mainmenu.SetActive(true);
        Showlevels.SetActive(false);
        optionsMenu.SetActive(false);

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
        functiongetting.Yes();
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

