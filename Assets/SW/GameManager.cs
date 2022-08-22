using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    [SerializeField, Tooltip("時間制限")]
    Text _timer;
    [SerializeField, Tooltip("スコア")]
    Text _score;
    [SerializeField, Tooltip("リザルトスコア")]
    Text _ResultScore;
    [SerializeField, Tooltip("リザルト画面")]
    GameObject _GameOver;
    public float _Time;
    private int Score;
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
            _GameOver.SetActive(true);
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
