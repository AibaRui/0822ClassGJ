using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    [SerializeField] GameObject _Close;
    [SerializeField] GameObject _open;

    public void ScneMove(string ScneName)
    {
        SceneManager.LoadScene(ScneName);
    }
    public void SetActive()
    {
        _Close.gameObject.SetActive(false);
        _open.gameObject.SetActive(true);
    }
}
