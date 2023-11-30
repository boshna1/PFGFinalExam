using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

     void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Ball")
        {
            Invoke("EnableFall",0.5f);
            Invoke("Destroy",2);

        }
    }

    void Destroy()
    {
        Destroy(this.gameObject);
    }

    void EnableFall()
    {
        rb.useGravity = true;
    }
}
