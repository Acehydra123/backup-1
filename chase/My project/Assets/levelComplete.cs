using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class levelComplete : MonoBehaviour
{
    public string nextLvl;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
      
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("x");
        if (collision.gameObject.tag == "Player") 
        {
            SceneManager.LoadScene(nextLvl);
        }
    }
}

