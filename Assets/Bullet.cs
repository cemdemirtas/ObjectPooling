using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float _speed;

    void OnEnable()
    {
        Invoke("Hide", 1f);                                                         
    }
    void Update()
    {
        transform.Translate(Vector3.right *Time.deltaTime * _speed);
    }
    void Hide()
    {
        this.gameObject.SetActive(false);   
    }
}
