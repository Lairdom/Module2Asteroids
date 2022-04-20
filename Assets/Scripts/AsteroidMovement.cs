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
        randomX = Random.Range(-0.4f,0.4f);
        randomY = Random.Range(-0.4f,0.4f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 velocity = new Vector3(randomX * Time.deltaTime,randomY * Time.deltaTime,0f);
        transform.position += velocity;
    }
}
