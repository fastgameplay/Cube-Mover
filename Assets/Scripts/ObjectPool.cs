using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour{
    public static ObjectPool Instance; 
    [SerializeField] GameObject ObjectPrefab;
    List<GameObject> _pooledObjects;
    

    void Awake(){
        Instance = this;
    }
    void Start(){
        _pooledObjects = new List<GameObject>();
    }
    public GameObject GetPooledObject(){
        for (int i = 0; i < _pooledObjects.Count; i++){
            if(_pooledObjects[i].activeInHierarchy == false)
            {
                return _pooledObjects[i];
            }
        }
        GameObject temp = Instantiate(ObjectPrefab, transform.position, Quaternion.identity, transform);
        temp.SetActive(false);
        _pooledObjects.Add(temp);
        return temp;
    }
}
