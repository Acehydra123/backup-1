using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShoot : MonoBehaviour
{
    public GameObject prefab;
    public float BulletSpeed = 10.0f;
    public float bulletLifetime = 2.0f;
    public AudioClip shootSound;
    // Update is called once per frame
    void Update()
    {
        //when mouse is clicked
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(10, 0);
            Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            Vector3 shootDir = mousePosition - transform.position;
            shootDir.Normalize();
            bullet.GetComponent<Rigidbody2D>().velocity = shootDir * BulletSpeed;
            Destroy(bullet, bulletLifetime);
            Camera.main.GetComponent<AudioSource>().PlayOneShot(shootSound);
        }
    }
}
