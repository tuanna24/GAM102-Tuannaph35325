using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    public Transform vitri1;
    public Transform vitri2;
    public Transform vitri3;
    public GameObject boomobject;
    float thoiGianRoi = 2f;
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
                case 1: StartCoroutine(SpawnBoom(vitri1.position)); break;
                case 2: StartCoroutine(SpawnBoom(vitri2.position)); break;
                case 3: StartCoroutine(SpawnBoom(vitri3.position)); break;
            }
        }
    }

    IEnumerator SpawnBoom(Vector3 position)
    {
        GameObject boom = Instantiate(boomobject, position, Quaternion.identity);
        yield return new WaitForSeconds(2f); // Chờ 2 giây
        Destroy(boom); // Hủy gameobject sau khi chờ
    }
}
