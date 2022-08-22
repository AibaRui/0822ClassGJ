using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    [Header("—Í‚Ì‹­‚³")]
    [Tooltip("—Í‚Ì‹­‚³")] [SerializeField] float _limitSpeed;

    Rigidbody2D _rb;
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
        _rb.AddForce(transform.up * 5, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if(_rb.velocity.x>_limitSpeed)
        {
            Vector2 velo = new Vector2(_limitSpeed, _rb.velocity.y);
            _rb.velocity = velo;
        }
        else if(_rb.velocity.y > _limitSpeed)
        {
            Vector2 velo = new Vector2(_rb.velocity.x,_limitSpeed);
            _rb.velocity = velo;
        }
    }
}
