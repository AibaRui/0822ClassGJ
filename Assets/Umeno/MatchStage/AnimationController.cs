using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] Animator _anim;
    [SerializeField] int _intarval;
    [SerializeField] string _animationName;
    float _timer;
    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        if(_timer >= _intarval)
        {
            _anim.Play(_animationName);
            _timer = 0;
        }
    }
}
