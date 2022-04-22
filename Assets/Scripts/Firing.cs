using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firing : MonoBehaviour
{
    [SerializeField] GameObject shot;
    [SerializeField] GameObject shot2;
    [SerializeField] GameObject turret;
    [SerializeField] float fireRate = 0.2f;
    [SerializeField] SpecialsUI _spUI;
    float timer = 0;
    public int secondary = 0;
    void Shoot() {
        // Instantiate the shot
            
        // Instantiate(shot, transform.position, transform.rotation);
        GameObject newShot = Instantiate(shot, turret.transform.position, turret.transform.rotation);
        Destroy(newShot,3);
        
    }
    void ShootSecondary() {
        // Instantiate the shot
            
        // Instantiate(shot, transform.position, transform.rotation);
        GameObject newShot2 = Instantiate(shot2, turret.transform.position, turret.transform.rotation);
        Destroy(newShot2,3);
        
    }

    public void getSecondary() {
        secondary++;
        _spUI.viewSpecials(secondary);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1")) {
            if (timer > fireRate) {
                Shoot();
                timer = 0;
            }
        }
        if (Input.GetButton("Fire2")) {
            if (timer > fireRate) {
                if (secondary != 0) {
                    ShootSecondary();
                    timer = 0;
                    secondary--;
                    _spUI.viewSpecials(secondary);
                }
            }
        }
        // if (Input.GetKeyDown(KeyCode.E)) {
            
        //     if (timer > fireRate) {
        //         Shoot();
        //         timer = 0;
        //     }
        // }
        timer += Time.deltaTime;
    }
}
