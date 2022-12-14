using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //GameManagerスクリプトがついているオブジェクトをアタッチ

    [SerializeField] int _intarval;
    [SerializeField] int _score;
    float _timer;
    // Start is called before the first frame update
    void Start()
    {
        //GameManagerがある場合動作するはず

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


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(AddScore(_score));
        }
    }
    IEnumerator AddScore(int Score)
    {
        GameManager _gameManager = GameObject.FindObjectOfType<GameManager>();
        _gameManager.AddScore(Score);
        yield return new WaitForSeconds(0.1f);
        Destroy(gameObject);
    }
}
