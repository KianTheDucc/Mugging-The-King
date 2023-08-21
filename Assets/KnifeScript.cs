using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeScript : MonoBehaviour
{
    public GameObject Knife;
    public GameObject mugger;
    public GameObject enemy;
    public float damage;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame 
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Click");
            Knife.SetActive(true);
            
        }
        if (Input.GetMouseButtonUp(0))
        {
            Knife.SetActive(false);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            collision.gameObject.GetComponent<CombatScript>().TakeDamage(10);
        }
        
    }
}
