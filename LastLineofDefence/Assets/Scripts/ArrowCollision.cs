using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ArrowCollision : MonoBehaviour
{
    //==== COMPONENTS ====
    public GameObject arrow;
   
    private Vector3 _arrowSpeed;
    private Vector3 _arrowDirection;
    private Vector3 _arrowRotation;

    //==== COLLISION PROTOCOL ====
    void OnCollisionEnter(Collision other)
    {
        /*
         * HITS THE GROUND
         */
        if (other.gameObject.tag == "Ground")
        {
            
            return;
        }
        /*
         *  HITS THE ENEMY
         */
        if (other.gameObject.tag == "Warrior")
        {
            
            DamageEnemy();
        }

        /*
         * HITS THE SHIELD
         */
        if (other.gameObject.tag == "Shield")
        {
            ReflectArrow();
            Destroy(arrow);
        }
      

        /*
         * HITS THE PLAYER
         */
        if (other.gameObject.tag == "Player")
        {
            DamagePlayer();
        }
 
    }
   
    //==== FUNCTIONS ====
    private void DamagePlayer()
    {
        Debug.Log("OW!");
      
    }
    private void ReflectArrow()
    {
        Debug.Log("BING");
        int soundChoice = Random.Range(1, 4);
        int soundCheck = soundChoice;
        Debug.Log("Sound: " + soundCheck.ToString() + " should play");

        if (soundChoice == 1){
            FindObjectOfType<SoundManager>().Play("Arrow hitting shield #1");
        }
        if (soundChoice == 2)
        {
            FindObjectOfType<SoundManager>().Play("Arrow hitting shield #2");
        }
        if (soundChoice == 3)
        {
            FindObjectOfType<SoundManager>().Play("Arrow hitting shield #3");
        }

    }

    private void DamageEnemy()
    {
        Debug.Log("Enemy Hit");
        
    }
}
