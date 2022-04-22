using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collision : MonoBehaviour
{
    GameObject callStartGame;
    [SerializeField] LivesUI _ui;
    [SerializeField] TextMeshProUGUI gameOver;
    Rigidbody2D rb;
    public bool invulnerable = false;
    int lives;
    public float invTimer = 0;

    void invFrames() {
        if (invTimer % 0.5f < 0.1f)
            GetComponent<SpriteRenderer>().enabled = false;
        else 
            GetComponent<SpriteRenderer>().enabled = true;
        if (invTimer <= 0) {
            invulnerable = false;
            GetComponent<SpriteRenderer>().enabled = true;
        }
        invTimer -= Time.deltaTime;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "Asteroid(Clone)" && invulnerable != true
        || col.name == "SmallAsteroid(Clone)" && invulnerable != true
        || col.name == "Shot(Clone)" && invulnerable != true) {
            if (col.name == "Shot(Clone)")
                Destroy(col.gameObject);
            
            gameObject.GetComponent<AudioSource>().Play();
            invulnerable = true;
            invTimer = 2;

            rb.velocity = new Vector2(0,0);            
            transform.position = new Vector3(0f,0f,0f);
            transform.rotation = Quaternion.Euler(0f,0f,0f);
            lives--;
            _ui.viewLives(lives);
            if (lives < 1) {
                gameOver.enabled = true;
                this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                this.gameObject.GetComponent<PolygonCollider2D>().enabled = false;            
                Destroy(this.gameObject,2);

            }


        }

        if (col.name == "PowerUp(Clone)") {
            gameObject.GetComponent<Firing>().getSecondary();
            Destroy(col.gameObject);
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        callStartGame = GameObject.Find("GameLogic");
        lives = callStartGame.GetComponent<StartGame>().lives;
        rb = GetComponent<Rigidbody2D>();
        invulnerable = true;
        invTimer = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (invulnerable == true)
            invFrames();
    }
}
