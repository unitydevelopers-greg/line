using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Line.Models {
    public class GameModel : MonoBehaviour {
        
        
        public float TimeLeft;
        public bool IsGameActive = false;

        public float TotalDistance = 0;


        public void StartGame() {
            
            TimeLeft = Config.START_TIME;
            IsGameActive = true;
            TotalDistance = 0;
        }


        private void Update() {

            if (IsGameActive) {
                TimeLeft -= Time.deltaTime;

                if (TimeLeft <= 0) {
                    GameOver();
                }
                
            }
        }


        public void Pause() {
            IsGameActive = false;
        }


        
        public void Resume() {
            IsGameActive = true;
        }

        public void GameOver() {
            IsGameActive = false;
        }
        
    }
}
