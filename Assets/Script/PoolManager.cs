using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    public static PoolManager instance;
    [SerializeField] private GameObject _BulletPrefab;
    [SerializeField] private GameObject _BulletContainer;
    [SerializeField] private List<GameObject> _BulletPool;
    [SerializeField] private int _bullets;
    private void Awake()
    {
        if (instance==null)
        {
            instance = this;
        }   
    }

    private List<GameObject> GenarateBullets(int numOfBullets)
    {
        for (int i = 0; i < numOfBullets; i++)
        {
            GameObject bullet = Instantiate(_BulletPrefab);
            bullet.transform.parent = _BulletContainer.transform;
            bullet.SetActive(false);
            _BulletPool.Add(bullet);
        }
        return _BulletPool;
    }
    private void Start()
    {
      _BulletPool=GenarateBullets(_bullets);  //Genarate desire number of bullet
    } 

    public GameObject RequestBullet() 
        {
        foreach (var bullet in _BulletPool) // while there is no active bullet
        {
            if (bullet.activeInHierarchy==false)
            {
                bullet.SetActive(true);
                return bullet;
            }
        }
        GameObject newbullet= Instantiate(_BulletPrefab);
        newbullet.transform.parent = _BulletContainer.transform;
        _BulletPool.Add(newbullet);
        return newbullet;
    }
}
