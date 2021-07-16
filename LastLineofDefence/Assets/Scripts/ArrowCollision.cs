using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowCollision : MonoBehaviour
{
    public Rigidbody arrow;
    public GameObject player;
    private Vector3 _arrowSpeed;
    private Vector3 _arrowDirection;
    private Vector3 _arrowRotation;

    void OnCollisionEnter(Collision other)
    {
        /*
         * HITS THE GROUND
         */
        if (other.gameObject.tag == "Ground")
        {
            arrow.constraints = RigidbodyConstraints.FreezeAll;
            arrow.velocity = Vector3.zero;
            arrow.angularVelocity = Vector3.zero;
            return;
        }
        /*
         *  HITS THE ENEMY
         */
        if (other.gameObject.tag == "Warrior")
        {
            arrow.constraints = RigidbodyConstraints.FreezeAll;
            arrow.velocity = Vector3.zero;
            arrow.angularVelocity = Vector3.zero;
            DamageEnemy();
        }

        /*
         * HITS THE SHIELD
         */
        Debug.Log("====SHIELD CHECK====");

        if (other.gameObject.tag == "Shield")
        {
            ReflectArrow();
        }

        
        /*
         * HITS THE PLAYER
         */
        else if (other.gameObject.tag == "Player")
        {
            DamagePlayer();
        }
 
    }
   

    private void DamagePlayer()
    {
        Debug.Log("OW!");
      //  GetComponent<PlayerController.FindObjectOfType>
    }
    private void ReflectArrow()
    {
        Debug.Log("BING, Saved it");
        _arrowSpeed = arrow.velocity;
        _arrowDirection = arrow.transform.position;
        //_arrowRotation = arrow.transform.r
        arrow.velocity = Vector3.zero;
        arrow.angularVelocity = Vector3.zero;
        //arrow.transform.Rotate
       
    }

    private void DamageEnemy()
    {
        Debug.Log("Enemy Hit");
        //Destroy(other.gameObject);
    }
}
