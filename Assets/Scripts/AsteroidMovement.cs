using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    float randomX, randomY;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        randomX = Random.Range(-0.4f,0.4f);
        randomY = Random.Range(-0.4f,0.4f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // rb.AddForce(new Vector2(randomX,randomY));
        Vector3 velocity = new Vector3(randomX * Time.deltaTime,randomY * Time.deltaTime,0f);
        transform.position += velocity;
    }
}
