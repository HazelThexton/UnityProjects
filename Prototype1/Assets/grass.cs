using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grass : MonoBehaviour
{

    public GameObject grassy;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Grow", 0f, 0.3f);
    }

    void Grow()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 pos = transform.position + new Vector3(0, -2, 0);
            Instantiate(grassy, pos, transform.rotation);
        }

        else if (Input.GetKey(KeyCode.A))
        {
            Vector3 pos = transform.position + new Vector3(0, -2, 0);
            Instantiate(grassy, pos, transform.rotation);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            Vector3 pos = transform.position + new Vector3(0, -2, 0);
            Instantiate(grassy, pos, transform.rotation);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            Vector3 pos = transform.position + new Vector3(0, -2, 0);
            Instantiate(grassy, pos, transform.rotation);
        }
    }
}
