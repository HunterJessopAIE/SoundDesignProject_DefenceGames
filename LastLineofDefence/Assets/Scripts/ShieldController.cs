using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldController : MonoBehaviour
{
    public GameObject player;
    public GameObject shieldPosTracker;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = shieldPosTracker.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = shieldPosTracker.transform.position;


        this.transform.rotation = new Quaternion(player.transform.rotation.x, player.transform.rotation.y, player.transform.rotation.z, player.transform.rotation.w);

    }
}
