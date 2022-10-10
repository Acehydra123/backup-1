using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slimeHealth : MonoBehaviour
{
    public int enemyHealth = 20;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string othertag = collision.gameObject.tag;
        if (othertag == "bullet")
        {
            enemyHealth --;
        
        }
if (enemyHealth <= 0) Destroy (gameObject);

    }
}
