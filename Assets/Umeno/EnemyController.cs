using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //GameManager�X�N���v�g�����Ă���I�u�W�F�N�g���A�^�b�`
    //[SerializeField] GameManager _gameManager;
    [SerializeField] int _intarval;
    [SerializeField] int _score;
    float _timer;
    // Start is called before the first frame update
    void Start()
    {
        //GameManager������ꍇ���삷��͂�
        //_gameManager = GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        _timer = Time.deltaTime;
        if(_timer >= _intarval)
        {
            Destroy(gameObject);
        }
    }

    //GameManager���A�^�b�`����Ă�g����
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if(collision.gameObject.tag == "Player")
    //    {
    //        StartCoroutine(AddScore(_score));
    //    }
    //}
    //IEnumerator AddScore(int Score)
    //{
    //    _gameManager.AddScore(Score);
    //    yield return new WaitForSeconds(0.1f);
    //    Destroy(gameObject);
    //}
}
