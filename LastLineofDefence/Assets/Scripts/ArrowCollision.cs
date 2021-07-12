﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowCollision : MonoBehaviour
{
    private GameObject _arrow;
    public GameObject player;
    private Vector3 _arrowCollision;
    private Vector3 _arrowDirection;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ground")
        {
            return;
        }

        Debug.Log("OnTriggerEntered");
        
        if (other.gameObject.tag == "Player")
        {
            /*
             * Use this line to test collision
             */

            //Destroy(other.gameObject);
            DamagePlayer();
        }
        
        if (other.gameObject.tag == "Shield")
        {
            ReflectArrow();
        }
        
        Debug.Log("TriggerEnded");
        
    }

    private void DamagePlayer()
    {
        Debug.Log("OW! Player hurt");
      //  GetComponent<PlayerController.FindObjectOfType>
    }
    private void ReflectArrow()
    {
        Debug.Log("BING, Saved it");
        //_arrowCollision = _arrow.GetComponent<Transform.>
    }
}
