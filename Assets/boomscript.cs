using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boomscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            HealthBar healthBar = other.GetComponent<HealthBar>();
            healthBar.PlayerDead();
        }
        if (other.CompareTag("dat"))
        {
            Destroy(gameObject);
        }
    }
}
