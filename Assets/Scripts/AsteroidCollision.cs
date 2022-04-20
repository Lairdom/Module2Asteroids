using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidCollision : MonoBehaviour
{
    public GameObject SmallAsteroid;
    GameObject scoreKeeper;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "Shot(Clone)") {
            Destroy(col.gameObject);
            Destroy(this.gameObject);

            Instantiate(SmallAsteroid, 
            this.gameObject.transform.position,
            Quaternion.Euler(0f,0f,Random.Range(-360,360)));

            Instantiate(SmallAsteroid, 
            this.gameObject.transform.position,
            Quaternion.Euler(0f,0f,Random.Range(-360,360)));

            Instantiate(SmallAsteroid, 
            this.gameObject.transform.position,
            Quaternion.Euler(0f,0f,Random.Range(-360,360)));  

            scoreKeeper = GameObject.Find("PlayerShip");
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
