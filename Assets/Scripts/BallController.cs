using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallController : MonoBehaviour
{
    bool GameStart;
    Vector3 BallMoveDirection = new Vector3(1,0,0);
    [SerializeField] private float speed;
    Rigidbody rb;
    bool XMove = false;
    bool ZMove = false;
    bool fall = false;
    UiManager uiManager;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        GameStart = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && GameStart == false)
        {
            GameStart = true;
            BallMoveDirection = new Vector3(0, 0, 1);
            ZMove = true;
        }
        if (GameStart == true) 
        {
            this.transform.Translate(BallMoveDirection * speed);
            if (Input.GetMouseButtonDown(0)) 
            {
                SwitchAxis();
            }
        }
        if (this.transform.position.y < 0) 
        {
            uiManager.GameOver();
            GameStart = false;
        }
        
    }

    void SwitchAxis()
    {
        if (XMove == true) 
        {
            ZMove = true;
            XMove = false;
            BallMoveDirection = new Vector3(0, 0, 1);
            return;
        }
        if (ZMove == true)
        {
            XMove = true;
            ZMove = false;
            BallMoveDirection = new Vector3(1, 0, 0);
            return;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag != "PlatformCube" && collision.transform.tag != "Diamond")
        {
            rb.useGravity = true;
        }
        if (collision.transform.tag == "Diamond")
        {
            Destroy(collision.gameObject);
        }

    }
}
