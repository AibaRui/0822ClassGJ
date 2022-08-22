using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRespawn : MonoBehaviour
{
    [SerializeField] Transform[] _respawnPosition;
    [SerializeField] GameObject _target;
    [SerializeField] int _intarval;
    public int Intarval { get => _intarval; }
    float _timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int n = Random.Range(0, _respawnPosition.Length - 1);
        _timer += Time.deltaTime;
        if(_timer >= _intarval)
        {
            Instantiate(_target, _respawnPosition[n].position, transform.rotation);
            _timer = 0;
        }
    }
}
