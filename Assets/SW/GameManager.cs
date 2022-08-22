using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    [SerializeField, Tooltip("éûä‘êßå¿")]
    Text _time;
    private float leftTime;
    // Start is called before the first frame update
    void Start()
    {
        leftTime = 300f;
        _time = GameObject.Find("TimeText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        leftTime -= Time.deltaTime;
        _time.text = "Time :" + (leftTime > 0f ? leftTime.ToString("0.00") : "0.00");
    }
}
