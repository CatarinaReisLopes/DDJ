using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeCutter : MonoBehaviour
{

    private void OnTriggerEnter2D (Collider2D collider){
        GameObject objectToDestroy = GameObject.FindGameObjectWithTag("Link");
        if(collider.GetComponent<CharacterController2D>() != null){
            Destroy (objectToDestroy);
            
        }
    }

}
