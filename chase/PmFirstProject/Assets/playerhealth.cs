using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playerhealth : MonoBehaviour
{
    public int health = 10;
    public Text healthText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

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
        }
    }
}
