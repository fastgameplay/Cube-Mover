using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour{
    [SerializeField] GameObject _cubePrefab;
    [SerializeField] PlayerInput _playerInput;
    private float _distance = 30;
    private float _speed = 2;

    void Start(){
         StartCoroutine(SpawnCubes(1));
    }

    IEnumerator SpawnCubes(float delay){
        while (true){
            yield return new WaitForSeconds(delay);
            Instantiate(_cubePrefab, transform.position, Quaternion.identity)
                .GetComponent<CubeMovement>().SetUp(_speed,_distance);
        }
    }

    public void UpdateSettings(){
        StopAllCoroutines();
        _distance = _playerInput.Distance;
        _speed = _playerInput.Speed;
        StartCoroutine(SpawnCubes(_playerInput.Delay));
    }
}
