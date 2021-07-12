using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowCollision : MonoBehaviour
{
    private GameObject _arrow;
    private Vector3 _arrowCollision;
    private Vector3 _arrowDirection;
    private void OnTriggerEnter(Collider other)
    {
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
    }

    private void DamagePlayer()
    {
        
    }
    private void ReflectArrow()
    {
        //_arrowCollision = _arrow.GetComponent<Transform.>
    }
}
