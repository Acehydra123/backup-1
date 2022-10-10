using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class playerhealth : MonoBehaviour
    
{
    public int health = 10;
    public Text healthText;
 
  
    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + health;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string othertag = collision.gameObject.tag;
        if(othertag == "damage")
        {
            health-= 2;
            if (health <= 0 )
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }

    }
}
