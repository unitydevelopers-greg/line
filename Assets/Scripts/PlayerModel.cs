using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel : MonoBehaviour {

    public Action<float> OnCurrentPathPositionUpdated;
    
    public float CurrentPathPosition;
    public AnimationCurve AccelerationCurve;
    public AnimationCurve DeAccelerationCurve;
    public float CurrentAcceration;
    public float CurrentSpeed;

    public float MaxSpeed = 1f;

    public bool IsMoving = false;
    
    
    public void ResetPosition() {
        CurrentPathPosition = 0;
        OnCurrentPathPositionUpdated?.Invoke(CurrentPathPosition);
    }


    public void Move() {
        IsMoving = true;
    }
    
    
    
    public void Stop() {
        IsMoving = false;
    }


    void Update() {

        if (IsMoving) {

            CurrentAcceration = AccelerationCurve.Evaluate(CurrentAcceration + Time.deltaTime);
            CurrentSpeed += CurrentAcceration;
            CurrentSpeed = Mathf.Clamp(CurrentSpeed, 0, MaxSpeed);
            CurrentPathPosition += CurrentSpeed;
        }
        else {
            CurrentAcceration = DeAccelerationCurve.Evaluate(CurrentAcceration + Time.deltaTime);
            CurrentSpeed -= CurrentAcceration;
            CurrentSpeed = Mathf.Clamp(CurrentSpeed, 0, MaxSpeed);
            CurrentPathPosition += CurrentSpeed;
        }
        
        
        
        OnCurrentPathPositionUpdated?.Invoke(CurrentPathPosition);
        
        
        
    }
    
    
 
}
