using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateOzyama : MonoBehaviour
{
    [Header("動くステージ")]
    [Tooltip("動くステージ")] [SerializeField] GameObject _stage;

    [Header("クールタイム")]
    [Tooltip("クールタイム")] [SerializeField] float _coolTime = 3;

    [Header("エリア判定のレイヤー")]
    [Tooltip("エリア判定のレイヤー")] [SerializeField] LayerMask _mask;


    bool _isOk;
    float _time;
    public RaycastHit2D hit; //レイキャストが当たったものを取得する入れ物

    private void OnEnable()
    {
        _time = 0;
    }
    void Start()
    {
        _time = 0;
    }

    void Update()
    {
        if (!_isOk)
        {
            _time += Time.deltaTime;
            if (_time > _coolTime)
            {
                _isOk = true;
                _time = 0;
            }
        }

        if (_isOk)
        {
            if (Input.GetMouseButtonDown(0))
            {
                var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, 100, _mask);
                if (hit)
                {
                    Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    mousePosition.z = 0;

                    var go =Instantiate( FindObjectOfType<SelectOzyama>()._ozyamaObject);
                    go.transform.position = mousePosition;
                    go.transform.SetParent(_stage.transform);
                    _isOk = false;
                    Debug.Log("A");
                }
            }
        }
    }

}