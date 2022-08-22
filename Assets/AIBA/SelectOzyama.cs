using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectOzyama : MonoBehaviour
{
    [Header("お邪魔の選択の枠")]
    [SerializeField] GameObject _window;

    [Header("お邪魔オブジェクト")]
    [SerializeField] GameObject[] _obj = new GameObject[2];

    [Header("お邪魔の選択場所")]
    [SerializeField] Transform[] _pos = new Transform[2];

    public GameObject _ozyamaObject;

    int num = 0;

    void Start()
    {
        num = 1;
        _ozyamaObject = _obj[0];
        _window.transform.position = _pos[0].position;
    }


    void Update()
    {
        float wh = Input.GetAxis("Mouse ScrollWheel");

        if (wh > 0)
        {


            num -= 1;
            if (num == 0)
            {
                num = _obj.Length;
            }

            Debug.Log(num);
            _window.transform.position = _pos[num - 1].position;
            _ozyamaObject = _obj[num - 1];
        }
        else if (wh < 0)
        {


            num += 1;
            if (num > _obj.Length)
            {
                num = 1;
            }
            Debug.Log(num);

            _window.transform.position = _pos[num - 1].position;
            _ozyamaObject = _obj[num - 1];
        }



    }
}
