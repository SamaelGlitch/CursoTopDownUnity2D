using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform Firepoint;
    public GameObject flechaprefab;
    public float shootspeed = 10;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(flechaprefab, Firepoint.position, Firepoint.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = Firepoint.forward * shootspeed;
            Destroy(bullet, 2f);
        }
    }

    
}
