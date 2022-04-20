using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject Asteroid;
    public int lives = 3;
    Vector3 velocity = new Vector3(0, 0, 0);
    void spawnAsteroids() {
        Instantiate(Asteroid, 
        new Vector3(Random.Range(-2.3f,2.3f),Random.Range(-0.75f,0.75f),0f),
        Quaternion.Euler(0f,0f,Random.Range(-360,360)));       
    }
    
    // Start is called before the first frame update
    void Start()
    {
        spawnAsteroids();
        spawnAsteroids();
        spawnAsteroids();
        spawnAsteroids();
        spawnAsteroids();
        spawnAsteroids();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (GameObject.FindGameObjectWithTag("Asteroid") == null) {
            spawnAsteroids();
        }
    }
}
