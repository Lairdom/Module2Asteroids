using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallAsteroidCollision : MonoBehaviour
{
    GameObject scoreKeeper;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "Shot(Clone)" || col.name == "Shot2(Clone)") {
            if (col.name == "Shot(Clone)")
                Destroy(col.gameObject);
            gameObject.GetComponent<AudioSource>().Play();
            this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            this.gameObject.GetComponent<PolygonCollider2D>().enabled = false;
            Destroy(this.gameObject,2);
            

            scoreKeeper = GameObject.Find("GameLogic");
            scoreKeeper.GetComponent<Score>().ChangeScore(50);
            
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
