using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeWarp : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        float getX, getY;
        getX = transform.position.x;
        getY = transform.position.y;
        if (col.name == "NorthEdge") {
            transform.position = new Vector3(getX,-0.9f,0f);
        }
        if (col.name == "SouthEdge") {
            transform.position = new Vector3(getX,0.9f,0f);
        }
        if (col.name == "WestEdge") {
            transform.position = new Vector3(2.5f,getY,0f);
        }
        if (col.name == "EastEdge") {
            transform.position = new Vector3(-2.5f,getY,0f);
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
