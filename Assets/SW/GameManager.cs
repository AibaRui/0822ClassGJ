using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject _player;
    [SerializeField] GameObject _stage;

    [SerializeField, Tooltip("時間制限")]
    Text _timer;
    [SerializeField, Tooltip("スコア")]
    Text _score;
    [SerializeField, Tooltip("リザルトスコア")]
    Text _ResultScore;
    [SerializeField, Tooltip("リザルト画面")]
    GameObject __CooperationGameOver;
    [SerializeField, Tooltip("リザルト画面")]
    GameObject __BattleGameOver;
    public float _Time;
    private int Score;
    [SerializeField,Tooltip("協力")]
    bool _inCooperation;
    [SerializeField,Tooltip("バトル")]
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
