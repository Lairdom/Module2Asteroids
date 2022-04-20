using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    int lives;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "Asteroid(Clone)" && Time.time > 2 
        || col.name == "SmallAsteroid(Clone)" 
        || col.name == "Shot(Clone)") {
            transform.position = new Vector3(0f,0f,0f);
            transform.rotation = Quaternion.Euler(0f,0f,0f);
            lives--;
            if (lives <= 0) {
                Debug.Log("Game Over");
                // Display Game Over Screen
                Destroy(this.gameObject);
            }


        }

    }
    // Start is called before the first frame update
    void Start()
    {
        lives = gameObject.GetComponent<StartGame>().lives;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
