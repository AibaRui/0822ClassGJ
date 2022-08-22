using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStageController : MonoBehaviour
{

    [Header("‰ñ“]‚Ì‘¬“x")]
   [Tooltip("‰ñ“]‚Ì‘¬“x")] [SerializeField] float _moveSpeed=0.4f;

    bool _isMove;
    bool _isRight;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void FixedUpdate()
    {
        if(_isMove)
        {
            if(_isRight)
            {
            Vector3 worldAngle = this.transform.eulerAngles;
            worldAngle.z -= _moveSpeed;
            transform.eulerAngles = worldAngle;
            }
            else
            {
            Vector3 worldAngle = this.transform.eulerAngles;
            worldAngle.z += _moveSpeed;
            transform.eulerAngles = worldAngle;
            }
        }


    }

    void Move()
    {
        var h = Input.GetAxisRaw("Horizontal");
 
        if(h>0)
        {
            _isRight = true;
            _isMove = true;
        }
        else if(h<0)
        {
            _isRight = false;
            _isMove = true;
        }
        else
        {
            _isMove = false;
        }

    }

}
