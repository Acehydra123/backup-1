using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
      

        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            string othertag = collision.gameObject.tag;
        string otherName = null;
        if (otherName == "damage") 
            {
            int health = 0;
            health -= 2;
            }
        }
    }


