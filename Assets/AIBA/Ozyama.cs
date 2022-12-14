using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ozyama : MonoBehaviour
{

    [Header("力の強さ")]
    [Tooltip("力の強さ")] [SerializeField] float _power = 2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            rb.AddForce(transform.up * _power, ForceMode2D.Impulse);
        }

    }

}
