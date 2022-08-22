using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject _player;
    [SerializeField] GameObject _stage;

    [SerializeField, Tooltip("���Ԑ���")]
    Text _timer;
    [SerializeField, Tooltip("�X�R�A")]
    Text _score;
    [SerializeField, Tooltip("���U���g�X�R�A")]
    Text _ResultScore;
    [SerializeField, Tooltip("���U���g���")]
    GameObject __CooperationGameOver;
    [SerializeField, Tooltip("���U���g���")]
    GameObject __BattleGameOver;
    public float _Time;
    private int Score;
    [SerializeField,Tooltip("����")]
    bool _inCooperation;
    [SerializeField,Tooltip("�o�g��")]
    bool _inBattle;
    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
        SetScoreText(Score);  
    }

    // Update is called once per frame
    void Update()
    {
        _Time -= Time.deltaTime;
        _timer.text = "Time :" + (_Time > 0f ? _Time.ToString("0.00") : "0.00");

        if (_Time < 0)
        {
            if (_inCooperation == true)
            {
                __CooperationGameOver.SetActive(true);
            }
            else if (_inBattle == true)
            {
                __BattleGameOver.SetActive(true);
            }

            _stage.SetActive(false);
          //  _player.SetActive(false);
        }
    }

    private void SetScoreText(int Score)
    {
        _score.text = "Score: " + Score.ToString();
        _ResultScore.text = "Score: " + Score.ToString();
    }
    public void AddScore(int point)
    {
        Score += point;
        SetScoreText(Score);
    }
}
