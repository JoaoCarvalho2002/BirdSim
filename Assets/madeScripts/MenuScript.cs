using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour
{
   [SerializeField] private GameObject Mainmenu;
   [SerializeField] private GameObject Showlevels;
   [SerializeField] private GameObject logo;

    public void StartGame()
    {
        Mainmenu.SetActive(false);
        Showlevels.SetActive(true);

    }
    public void backmainmenu()
    {
        Mainmenu.SetActive(true);
        Showlevels.SetActive(false);

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
    public void LoadpreviousSCENE()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void LoadnextSCENE()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

