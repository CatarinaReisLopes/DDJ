using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateStares : MonoBehaviour
{
    public GameObject escadaria;

    public Collider2D ball;

    private void OnTriggerEnter2D (Collider2D collider){
        //GameObject objectToDestroy = GameObject.FindGameObjectWithTag("LinkBall");
    

        if(collider.IsTouching(ball)){
            escadaria.SetActive(true);
        }
    }
}
