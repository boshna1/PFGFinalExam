using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Transform Ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Ball.position.y > -1)
        {
            this.transform.position = Ball.position + new Vector3(-11, 16, -14);
        }

       
    }
}
