using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlatformGeneration : MonoBehaviour
{
    bool GameStart;
    public GameObject platform;
    public GameObject diamond;
    Vector3 placement = new Vector3(4.5f,0.25f,5.5f);
    bool timer = true;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 21; i++)
        {
            GenerateTile();
            int random = Random.Range(0,2);
            if (random == 0)
            {
                placement += new Vector3(1,0,0);
            }
            if (random == 1)
            {
                placement += new Vector3(0, 0, 1);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            GameStart = true;
        }
        if (GameStart == true)
        {
            if (timer == true)
            {
                GenerateTile();
                int random = Random.Range(0, 2);
                if (random == 0)
                {
                    placement += new Vector3(1, 0, 0);
                }
                if (random == 1)
                {
                    placement += new Vector3(0, 0, 1);
                }
                GenerateDiamond();
                timer = false;
                Invoke("TimerReset", 0.2f);
            }
        }
        
    }

    void GenerateTile()
    {
     
        Instantiate(platform, placement, Quaternion.identity);
    }

    void TimerReset()
    {
        timer = true;
    }

    void GenerateDiamond()
    {
        int random = Random.Range(0, 5);
        if (random == 0)
        {
            GameObject newDiamond = Instantiate(diamond, placement + new Vector3(0,1,0), Quaternion.identity);
            newDiamond.transform.localScale += (new Vector3(40,40,40));
        }
    }
}
