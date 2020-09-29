using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public PlayerModel PlayerModel;


    public void MoveForward() {
        PlayerModel.Move();
    }
    
    public void StopMoving() {
        PlayerModel.Stop();
    }
    
}
