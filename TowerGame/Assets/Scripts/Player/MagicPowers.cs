using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicPowers : MonoBehaviour
{

    [SerializeField] public Transform firepoint;
    [SerializeField] public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Attack();
        }

       
    }

 void Attack()
        {
            Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        }

}
