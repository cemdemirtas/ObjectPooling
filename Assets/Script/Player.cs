using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject _BulletPrefab;
    private void Update()
    {
        Fire();
    }
    private void Fire()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject bullet = PoolManager.instance.RequestBullet();
            bullet.transform.position = Vector3.zero;
        }
    }
}
