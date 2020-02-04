using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour
{

    public AudioClip shoot;
    public Rigidbody projectile0;
    public Rigidbody projectile1;
    public Rigidbody projectile2;
    public Rigidbody projectile3;
    public Rigidbody projectile4;
    public Rigidbody projectile5;
    public Rigidbody projectile6;
    public Rigidbody projectile7;
    public Rigidbody projectile8;
    public Rigidbody projectile9;

    public float speed = 20;
    public float torque;
    int random;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1")) {
            random = Random.Range(0, 10);
                
            GetComponent<AudioSource>().PlayOneShot(shoot);

            /* System.Random r = new System.Random();*/


            if (random == 0)
            {
                Rigidbody instantiatedProjectile = Instantiate(projectile0,
                                              transform.position,
                                              transform.rotation)
   as Rigidbody;

                instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));

                float turn = Input.GetAxis("Horizontal");
                projectile0.AddRelativeTorque(Vector3.up * torque * turn);
            }


            if (random == 1)
            {
                Rigidbody instantiatedProjectile = Instantiate(projectile1,
                                              transform.position,
                                              transform.rotation)
   as Rigidbody;

                instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));

                float turn = Input.GetAxis("Horizontal");
                projectile1.AddRelativeTorque(Vector3.up * torque * turn);
            }
            if (random == 2)
            {
                Rigidbody instantiatedProjectile = Instantiate(projectile2,
                                              transform.position,
                                              transform.rotation)
   as Rigidbody;

                instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));

                float turn = Input.GetAxis("Horizontal");
                projectile2.AddRelativeTorque(Vector3.up * torque * turn);
            }
            if (random == 3)
            {
                Rigidbody instantiatedProjectile = Instantiate(projectile3,
                                              transform.position,
                                              transform.rotation)
   as Rigidbody;

                instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));

                float turn = Input.GetAxis("Horizontal");
                projectile4.AddRelativeTorque(Vector3.up * torque * turn);
            }
            if (random == 4)
            {
                Rigidbody instantiatedProjectile = Instantiate(projectile4,
                                              transform.position,
                                              transform.rotation)
   as Rigidbody;

                instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));

                float turn = Input.GetAxis("Horizontal");
                projectile4.AddRelativeTorque(Vector3.up * torque * turn);
            }
            if (random == 5)
            {
                Rigidbody instantiatedProjectile = Instantiate(projectile5,
                                              transform.position,
                                              transform.rotation)
   as Rigidbody;

                instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));

                float turn = Input.GetAxis("Horizontal");
                projectile5.AddRelativeTorque(Vector3.up * torque * turn);
            }
            if (random == 6)
            {
                Rigidbody instantiatedProjectile = Instantiate(projectile6,
                                              transform.position,
                                              transform.rotation)
   as Rigidbody;

                instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));

                float turn = Input.GetAxis("Horizontal");
                projectile6.AddRelativeTorque(Vector3.up * torque * turn);
            }
            if (random == 7)
            {
                Rigidbody instantiatedProjectile = Instantiate(projectile7,
                                              transform.position,
                                              transform.rotation)
   as Rigidbody;

                instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));

                float turn = Input.GetAxis("Horizontal");
                projectile7.AddRelativeTorque(Vector3.up * torque * turn);
            }
            if (random == 8)
            {
                Rigidbody instantiatedProjectile = Instantiate(projectile8,
                                              transform.position,
                                              transform.rotation)
   as Rigidbody;

                instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));

                float turn = Input.GetAxis("Horizontal");
                projectile8.AddRelativeTorque(Vector3.up * torque * turn);
            }
            if (random == 9)
            {
                Rigidbody instantiatedProjectile = Instantiate(projectile9,
                                              transform.position,
                                              transform.rotation)
   as Rigidbody;

                instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));

                float turn = Input.GetAxis("Horizontal");
                projectile9.AddRelativeTorque(Vector3.up * torque * turn);
            }
        }
            }
}
