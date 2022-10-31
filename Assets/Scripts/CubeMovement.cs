using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour{
    Vector3 _currentPos{ get {return transform.position;} }
    Vector3 _startPos;

    float _speed;
    float _distance;

    public void SetUp(float speed, float distance){
        _speed = speed;
        _distance = distance;
        _startPos = _currentPos;
        gameObject.SetActive(true);

    }

    void Update(){
        if(Vector3.Distance(_startPos,_currentPos) > _distance){
            gameObject.SetActive(false);
        }
        Movement();
    }

    void Movement(){
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }

}
