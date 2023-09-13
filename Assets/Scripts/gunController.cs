using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunController : MonoBehaviour
{
    public float Damage = 10f;
    public float range = 1000f;

    public Camera fpsCam;

    public ParticleSystem gunflash;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();

        }
    }

    void Shoot()

    {
        gunflash.Play();
        RaycastHit hitinfo;

        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hitinfo, range))
        {
            Debug.Log(hitinfo.transform.name);


            targetComponent target = hitinfo.transform.GetComponent<targetComponent>();

            if (target != null)
            {
                target.TakeDamage(Damage);
            }

        }

    }
}
