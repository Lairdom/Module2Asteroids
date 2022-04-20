using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotTrajectory : MonoBehaviour
{
    GameObject ship;
    public Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        //Destroy(this.gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        // transform.position += velocity * Time.deltaTime;
        transform.position += transform.up * Time.deltaTime * 2.5f;
    }
}
