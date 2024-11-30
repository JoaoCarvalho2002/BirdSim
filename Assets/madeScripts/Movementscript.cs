using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Movementscript : MonoBehaviour
{
    //É com enorme prazer que anuncio que todo o código aqui presente é de Cristo Rei 
    //e não da pessoa que foi apontada como programador ✟
    public GameObject obj;
    public GameObject currentScene;
    public CinemachineVirtualCamera cinemachineVirtualCamera;
    public CinemachineTrackedDolly cinemachineTrackedDolly;
    float unit = 0.1F;
    public CinemachineVirtualCamera currentCamera;

    private Texture2D screenCapture;
    [SerializeField] private Image photoDisplayArea;    
    [SerializeField] private GameObject photoFrame;
    [SerializeField] private GameObject flash;
    [SerializeField] private float flashtime;
    //saveimage
    [SerializeField]private GameObject pic1;
    private Image image1;
    [SerializeField]private GameObject pic2;
    private Image image2;
    [SerializeField]private GameObject pic3;
    private Image image3;
    [SerializeField]private GameObject pic4;
    private Image image4;
    string birdname;
    //Endgame UI
    [SerializeField] private GameObject endbackground;
    [SerializeField] private GameObject startbackground;
    [SerializeField] private GameObject secondtimer;
    public string textendgame;
    //TIMER
    [SerializeField] private GameObject timerturnONOFF;
    Timer neededScript;
    public float timer2 = 0.0f;
    //birdUI
    [SerializeField] private GameObject BirdsUIONOFF;    
    [SerializeField] private GameObject BlueNO;
    [SerializeField] private GameObject BlueYES;
    [SerializeField] private GameObject RedNO;
    [SerializeField] private GameObject RedYES;
    [SerializeField] private GameObject ChickaNO;
    [SerializeField] private GameObject ChickaYES;
    [SerializeField] private GameObject RobinNO;
    [SerializeField] private GameObject RobinYES;
    [SerializeField] private GameObject CrowNO;
    [SerializeField] private GameObject CrowYES;
    [SerializeField] private GameObject GoldNO;
    [SerializeField] private GameObject GoldYES;

    private bool bluecheck = false;
    private bool redcheck = false;
    private bool chickacheck = false;
    private bool robincheck = false;
    private bool crowcheck = false;
    private bool goldcheck = false;
    private bool viewingPhoto;
    public bool camOn=false;

    public List<Collider> collidersInFrustrum = new();
    void Start()
    {
        
        Mouselock();
        image1 = pic1.GetComponent<Image>();
        image2 = pic2.GetComponent<Image>();
        image3 = pic3.GetComponent<Image>();
        image4 = pic4.GetComponent<Image>();
        neededScript = GameObject.FindGameObjectWithTag("Needed").GetComponent<Timer>();

        


        var CinemachineTrackedDolly = currentCamera.GetCinemachineComponent<CinemachineTrackedDolly>();
        cinemachineTrackedDolly = currentCamera.GetCinemachineComponent<CinemachineTrackedDolly> ();
        

    }

    void Update()
    {   
        if (Input.GetKey("w"))
        {
            cinemachineTrackedDolly.m_PathPosition = cinemachineTrackedDolly.m_PathPosition + unit;
        }
        if (Input.GetKey("s"))
        {
            cinemachineTrackedDolly.m_PathPosition = cinemachineTrackedDolly.m_PathPosition - unit;
        }
        CameraOnOff();
        TakePick();
        
    }
    private void CameraOnOff()
    {

        if(Input.GetKeyUp("space"))
        {
            camOn=!camOn;

            if(camOn==true)
            {
                obj.SetActive(true);
                cinemachineVirtualCamera.m_Lens.FieldOfView = 20;
            }
            if(camOn==false)
            {
                obj.SetActive(false);
                cinemachineVirtualCamera.m_Lens.FieldOfView = 40;
            }
                
            
        }
   
    }
    private void TakePick()
    {
        if(camOn==true && Input.GetMouseButtonDown(0) && viewingPhoto==false)
        {
            StartCoroutine(CapturePhoto());
        }
        else if(camOn==false && Input.GetMouseButtonDown(0) && viewingPhoto==true)
        {
            RemovePhoto();
        }
    }
    IEnumerator CapturePhoto()
    {   
        Plane[] planes= GeometryUtility.CalculateFrustumPlanes(Camera.main);
       Collider[] colliders = FindObjectsOfType<Collider>();

       foreach(Collider collider in colliders){
        if(GeometryUtility.TestPlanesAABB(planes, collider.bounds)){
            
            lb_Bird bird;
            if(collider.gameObject.TryGetComponent<lb_Bird>(out bird)){
                //Debug.Log("" + bird.name);
                if(bird.name == "lb_blueJayHQ"){
                    if(currentScene.name == "Scene1" || currentScene.name == "Scene2"){
                        BlueYES.gameObject.SetActive(true);
                        BlueNO.gameObject.SetActive(false);
                        bluecheck=true; 
                    }
                    
                    screenCapture = new Texture2D(Screen.width, Screen.height,TextureFormat.RGB24, false);
                    Sprite screenshotSprite = Sprite.Create(screenCapture, new Rect(0,0,screenCapture.width, screenCapture.height),new Vector2(0.5f,0.5f));
                    image1.sprite = screenshotSprite;

                }
                if(bird.name == "lb_cardinalHQ"){
                    if(currentScene.name == "Scene1" || currentScene.name == "Scene2"){
                        RedYES.gameObject.SetActive(true);
                        RedNO.gameObject.SetActive(false);
                        redcheck=true;
                    }
                    

                    screenCapture = new Texture2D(Screen.width, Screen.height,TextureFormat.RGB24, false);
                    Sprite screenshotSprite2 = Sprite.Create(screenCapture, new Rect(0,0,screenCapture.width, screenCapture.height),new Vector2(0.5f,0.5f));
                    image2.sprite = screenshotSprite2;
                    
                    
                         
                }
                if(bird.name == "lb_chickadeeHQ"){
                    if (currentScene.name == "Scene1")
                    {
                        ChickaYES.gameObject.SetActive(true);
                        ChickaNO.gameObject.SetActive(false);
                        chickacheck=true;
                    }
                    

                    screenCapture = new Texture2D(Screen.width, Screen.height,TextureFormat.RGB24, false);
                    Sprite screenshotSprite3 = Sprite.Create(screenCapture, new Rect(0,0,screenCapture.width, screenCapture.height),new Vector2(0.5f,0.5f));
                    image3.sprite = screenshotSprite3;
                    
                    
                   
                    
                }
                if(bird.name == "lb_robinHQ"){
                    if (currentScene.name == "Scene1" ){
                        RobinYES.gameObject.SetActive(true);
                        RobinNO.gameObject.SetActive(false);
                        robincheck=true;
                    }
                    
                    
                    screenCapture = new Texture2D(Screen.width, Screen.height,TextureFormat.RGB24, false);
                    Sprite screenshotSprite4 = Sprite.Create(screenCapture, new Rect(0,0,screenCapture.width, screenCapture.height),new Vector2(0.5f,0.5f));
                    image4.sprite = screenshotSprite4;
                    
                    
                }if(bird.name == "lb_crowHQ"){
                    if (currentScene.name == "Scene2"){
                        CrowYES.gameObject.SetActive(true);
                        CrowNO.gameObject.SetActive(false);
                        crowcheck=true;
                    }
                    
                    
                    screenCapture = new Texture2D(Screen.width, Screen.height,TextureFormat.RGB24, false);
                    Sprite screenshotSprite3 = Sprite.Create(screenCapture, new Rect(0,0,screenCapture.width, screenCapture.height),new Vector2(0.5f,0.5f));
                    image3.sprite = screenshotSprite3;
                    
                    
                }if(bird.name == "lb_goldFinchHQ"){
                    if (currentScene.name == "Scene2")
                    {
                        GoldYES.gameObject.SetActive(true);
                        GoldNO.gameObject.SetActive(false);
                        goldcheck=true;

                    }
                    
                    
                    screenCapture = new Texture2D(Screen.width, Screen.height,TextureFormat.RGB24, false);
                    Sprite screenshotSprite4 = Sprite.Create(screenCapture, new Rect(0,0,screenCapture.width, screenCapture.height),new Vector2(0.5f,0.5f));
                    image4.sprite = screenshotSprite4;
                    
                    
                }
        

                collidersInFrustrum.Add(collider);

             bird.hasBeenPhotographed = true;

            }
        }
       }
        obj.SetActive(false);
        BirdsUIONOFF.gameObject.SetActive(false);
        timerturnONOFF.gameObject.SetActive(false);
        viewingPhoto = false;
        yield return new WaitForEndOfFrame();

        Rect regionToRead =new Rect(0, 0, Screen.width,Screen.height);

        screenCapture.ReadPixels(regionToRead,0,0,false);
        screenCapture.Apply();
        Debug.Log(screenCapture);
        ShowPhoto();
    }
    void ShowPhoto()
    {
        Sprite photoSprite = Sprite.Create(screenCapture,new Rect(0.0f,0.0f,screenCapture.width,screenCapture.height), new Vector2(0.5f,0.5f),100.0f);
        photoDisplayArea.sprite = photoSprite;
        obj.SetActive(false);
        camOn=false;
        photoFrame.SetActive(true);
        BirdsUIONOFF.gameObject.SetActive(true);
        timerturnONOFF.gameObject.SetActive(true);
        StartCoroutine(CameraFlash());
        viewingPhoto=true;
        cinemachineVirtualCamera.m_Lens.FieldOfView = 40;
    }
    IEnumerator CameraFlash()
    {
        flash.SetActive(true);
        yield return new WaitForSeconds(flashtime);
        flash.SetActive(false);
    }
    void RemovePhoto()
    {
        viewingPhoto = false;
        photoFrame.SetActive(false);
        Endgame();
    }
    void Endgame()
    {
        if(bluecheck==true && redcheck==true && chickacheck==true && robincheck==true || bluecheck==true && redcheck==true && goldcheck==true && crowcheck==true)
        {
            neededScript.StopTimer();
            
            if(viewingPhoto==false)
            {
                MouseUNlock();
                textendgame = neededScript.textTimer.text;
                secondtimer.GetComponent<TextMeshProUGUI>().text=textendgame;
                endbackground.SetActive(true);
                startbackground.SetActive(false);
            }
                 
        }
    }
    void Mouselock()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void MouseUNlock()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

}
