using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firing : MonoBehaviour
{
    [SerializeField] GameObject shot;
    [SerializeField] GameObject turret;
    [SerializeField] float fireRate = 0.2f;
    float timer = 0;
    void Shoot() {
        // Instantiate the sho
            
        // Instantiate(shot, transform.position, transform.rotation);
        GameObject newShot = Instantiate(shot, turret.transform.position, turret.transform.rotation);
        Destroy(newShot,3);
        
        
        
        // GameObject newLuoti = Instantiate(luoti, shootEmpty.transform);
        // Destroy(newLuoti,10);
        // MoveLuoti moveLuoti = newLuoti.GetComponent<MoveLuoti>();
        // moveLuoti.velocity = distanceVector.normalized * 4.0f;
        // timer = 0;

        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) {
            
            if (timer > fireRate) {
                Shoot();
                timer = 0;
            }
        }
        timer += Time.deltaTime;
    }
}
