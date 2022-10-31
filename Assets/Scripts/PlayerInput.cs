using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInput : MonoBehaviour{
    [SerializeField] InputField _timeInput;
    [SerializeField] InputField _distanceInput;
    [SerializeField] InputField _speedInput;

    public float Delay { get { return ValidateFloat(_timeInput.text);}}
    public float Speed { get { return ValidateFloat(_speedInput.text);}}
    public float Distance { get { return ValidateFloat(_distanceInput.text);}}

    float ValidateFloat(string input){
        float output = float.Parse(input);
        if(output > 0) return output;
        return 0;
    }
    
}
