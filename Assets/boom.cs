using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boom : MonoBehaviour
{
    public Transform vitri1;
    public Transform vitri2;
    public Transform vitri3;
    public GameObject boomobject;
    float thoiGianRoi = 10f;
    float timer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= thoiGianRoi)
        {
            timer = 0f;
            int random = Random.Range(1, 4);
            switch (random)
            {
                case 1: Instantiate(boomobject,vitri1.position,Quaternion.identity); break;
                case 2: Instantiate(boomobject,vitri2.position,Quaternion.identity); break;
                case 3: Instantiate(boomobject,vitri3.position,Quaternion.identity); break;
            }
        }
    }  
}
