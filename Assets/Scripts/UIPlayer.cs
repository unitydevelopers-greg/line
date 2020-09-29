using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPlayer : MonoBehaviour {

    public PlayerModel PlayerModel;
    public PlayerController PlayerController;


    private void OnEnable() {
        PlayerModel.OnCurrentPathPositionUpdated += OnCurrentPathPositionUpdated;
    }
    
    private void OnDisable() {
        PlayerModel.OnCurrentPathPositionUpdated -= OnCurrentPathPositionUpdated;
    }

    private void OnCurrentPathPositionUpdated(float currentPathPosition) {
  
        this.transform.localPosition = new Vector3(0, currentPathPosition, 0);
        
        
    }


    void Update() {

        if (Input.GetButtonDown(KeyCode.Space.ToString())) {
            PlayerController.MoveForward();
        }
        
        if (Input.GetButtonUp(KeyCode.Space.ToString())) {
            PlayerController.StopMoving();
        }
        
        
    }
    
}
