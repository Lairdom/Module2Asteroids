using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject Asteroid;
    [SerializeField] GameObject scoreKeeper;
    [SerializeField] GameObject collision;
    public int lives = 3;
    int stage, bonus, loopMax;

    void spawnAsteroids() {

        Instantiate(Asteroid, 
        new Vector3(Random.Range(-2.3f,2.3f),Random.Range(-0.75f,0.75f),0f),
        Quaternion.Euler(0f,0f,Random.Range(-360,360)));  
        //Vector2.Distance(transform.position,vihu.transform.position);     
    }
    
    void initStage() {
        for (int loop=0; loop < loopMax; loop++) {
                spawnAsteroids();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        stage = 1;
        loopMax = 4;
        initStage();


    }

    // Update is called once per frame
    void Update()
    {
        
        if (GameObject.FindGameObjectWithTag("Asteroid") == null) {
            if (stage < 3)
                bonus = stage * 1000;
            if (stage >= 3 && stage < 6)
                bonus = stage * 1500;
            if (stage >= 6)
                bonus = stage * 2000;
            gameObject.GetComponent<Score>().ChangeScore(bonus);
            stage++;
            loopMax += 2;
            initStage();
            collision.GetComponent<Collision>().invulnerable = true;
            collision.GetComponent<Collision>().invTimer = 2;
        }
    }
}
