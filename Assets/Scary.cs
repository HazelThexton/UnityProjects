using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scary : MonoBehaviour
{
    public GameObject Plane;
    public AudioClip jaws;
    public float speed;

    //Detect collisions between the GameObjects with Colliders attached
    void OnControllerColliderHit(ControllerColliderHit hit)

    {
        if (hit.collider.gameObject.name == "Plane")
        {
            GetComponent<AudioSource>().PlayOneShot(jaws);
        }
        

    }
    }
