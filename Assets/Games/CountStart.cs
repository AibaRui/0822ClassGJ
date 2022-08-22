using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountStart : MonoBehaviour
{
    [SerializeField] Text _text;
    [SerializeField] GameObject _stage;
    [SerializeField] GameObject _player;
    [SerializeField] GameObject _panel;
    [SerializeField] GameObject _gm;
    void Start()
    {
        _text.text = "       3";
        StartCoroutine(EE());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator EE()
    {
        yield return new WaitForSeconds(1);
        _text.text = "       2";
        yield return new WaitForSeconds(1);
        _text.text = "       1";
        yield return new WaitForSeconds(1);
        _text.text = "    Start";
        yield return new WaitForSeconds(2);
        _text.text = "";
        _stage.SetActive(true);
        _player.SetActive(true);
       // _panel.SetActive(false);
        _gm.SetActive(true);
    }
}