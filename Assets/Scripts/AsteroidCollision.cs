using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidCollision : MonoBehaviour
{
    public GameObject SmallAsteroid;
    public GameObject powerUp;
    // public AudioSource audio;
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
            
            int dropChance = Random.Range(0,6);
            if (dropChance == 5) {
                Instantiate(powerUp, this.gameObject.transform.position, Quaternion.Euler(0f,0f,0f));
            }
            Debug.Log(dropChance);
            Instantiate(SmallAsteroid, 
            this.gameObject.transform.position,
            Quaternion.Euler(0f,0f,Random.Range(-360,360)));

            Instantiate(SmallAsteroid, 
            this.gameObject.transform.position,
            Quaternion.Euler(0f,0f,Random.Range(-360,360)));

            Instantiate(SmallAsteroid, 
            this.gameObject.transform.position,
            Quaternion.Euler(0f,0f,Random.Range(-360,360)));  

            scoreKeeper = GameObject.Find("GameLogic");
            scoreKeeper.GetComponent<Score>().ChangeScore(100);
            // Gain score

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
