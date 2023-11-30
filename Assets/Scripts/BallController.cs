using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    bool GameStart = false;
    Vector3 BallMoveDirection = new Vector3(1,0,0);
    float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && GameStart == false)
        {
            GameStart = true;
            BallMoveDirection = new Vector3(1, 0, 0) * speed;
        }
        if (GameStart == true) 
        {
            if (Input.GetMouseButtonDown(0)) 
            {
                SwitchAxis();
            }
        }
    }

    void SwitchAxis()
    {
        if (BallMoveDirection == new Vector3(1, 0, 0))
        {
            BallMoveDirection = new Vector3(0, 0, 1) * speed;
        }
        if (BallMoveDirection == new Vector3(0, 0, 1))
        {
            BallMoveDirection = new Vector3(1, 0, 0) * speed;
        }
    }
}
