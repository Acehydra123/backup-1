using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slimeMovement : MonoBehaviour
{
    public GameObject player;
    public float close = 5.0f;
    public float speed = 3.0f;

    // Update is called once per frame
    void Update()
    {
        Vector3 chaseDir = player.transform.position - transform.position;
        float chaseDist = chaseDir.magnitude;
        chaseDir.Normalize();
        if(chaseDist <= close)
        {
            //chase the player
            GetComponent<Rigidbody2D>().velocity = chaseDir;
            GetComponent<Animator>().SetFloat("xint", chaseDir.x);
            GetComponent<Animator>().SetFloat("yint", chaseDir.y);

        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            GetComponent<Animator>().SetFloat("xint", 0);
            GetComponent<Animator>().SetFloat("yint", 0);
        }
        
    }
}
