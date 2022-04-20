using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallAsteroidCollision : MonoBehaviour
{
    GameObject scoreKeeper;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "Shot(Clone)") {
            Destroy(col.gameObject);
            Destroy(this.gameObject);
            
            scoreKeeper = GameObject.Find("PlayerShip");
            scoreKeeper.GetComponent<Score>().ChangeScore(100);
            
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
