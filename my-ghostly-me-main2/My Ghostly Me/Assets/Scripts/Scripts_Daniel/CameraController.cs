using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cinemachine{
public class CameraController : MonoBehaviour
{

    //public CinemachineBrain brain;
    public CinemachineVirtualCamera camera;
    public Transform toyPosition;
    Transform ghostPosition;

    // Update is called once per frame
    void Start(){
        ghostPosition = camera.m_Follow;
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Q)){
            camera.m_Follow = ghostPosition;
        }
        
    }

    public void ControlToy(){
        camera.m_Follow = toyPosition;
    }

    public void GoBackToGhost(){
        camera.m_Follow = ghostPosition;
    }
    
}
}