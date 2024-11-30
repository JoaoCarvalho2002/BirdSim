using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.UI;
public class MouseSensibility : MonoBehaviour// CinemachineExtension
{
    [SerializeField] public Slider slider;
    [SerializeField] public CinemachineVirtualCamera virtualcam1;
    float CamSensitivity;
    // Start is called before the first frame update
    void Start()
    {
        CamSensitivity = 0.6f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SetCamSensitivity(float sensitivity)
    {
        CamSensitivity = sensitivity;
        
    }
   // protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase virtualcam1, CinemachineCore.Stage stage, ref CameraState cameraState  , float r)
   // {
        
       // float speedX = virtualcam1.m_Aim.m_XAxis.m_MaxSpeed;
       // float speedY = virtualcam1.m_YAxis.m_MaxSpeed;

        //virtualcam1.m_XAxis.m_MaxSpeed = speedX * CamSensitivity;
        //virtualcam1.m_YAxis.m_MaxSpeed = speedY * CamSensitivity;

       // slider.onValueChanged.AddListener(SetCamSensitivity);
    //}
}
