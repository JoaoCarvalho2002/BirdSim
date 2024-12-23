using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.UI;
public class MouseSensibility : MonoBehaviour
{
    [SerializeField] public Slider slider;
    [SerializeField] public CinemachineVirtualCamera vcam;
    float CamSensitivity;
    // Start is called before the first frame update
    void Start()
    {
        CamSensitivity = 60;
        slider.value = CamSensitivity;
        vcam.GetCinemachineComponent<CinemachinePOV>().m_VerticalAxis.m_MaxSpeed = CamSensitivity;
        vcam.GetCinemachineComponent<CinemachinePOV>().m_HorizontalAxis.m_MaxSpeed = CamSensitivity;
    }

    // Update is called once per frame
    void Update()
    {
        CamSensitivity=slider.value;
        vcam.GetCinemachineComponent<CinemachinePOV>().m_VerticalAxis.m_MaxSpeed = CamSensitivity;
        vcam.GetCinemachineComponent<CinemachinePOV>().m_HorizontalAxis.m_MaxSpeed = CamSensitivity;
        
        
    }

}
