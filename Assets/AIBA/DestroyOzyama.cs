using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOzyama : MonoBehaviour
{
    [Header("���ז��̑I���̘g")]
    [SerializeField] float _destroyTime=3;
    void Start()
    {
        StartCoroutine(Des());
    }

    IEnumerator Des()
    {
        yield return new WaitForSeconds(_destroyTime);
        Destroy(gameObject);
        Destroy(gameObject);
    }

}
