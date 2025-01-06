using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameDevWithMarco.Singleton;
using UnityEngine.SocialPlatforms.Impl;
using GameDevWithMarco.Data;

namespace GameDevWithMarco.Managers
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] GlobalData globalData;

        private void Start()
        {
            if (globalData != null)
            {
                globalData.ResetsScore();
                globalData.SetTheScoreRequiredToWin();
            }
            else
            {
                Debug.LogWarning("GlobalData not asigned to GM");
            }
            
        }

        public void GameWon()
        {
            Time.timeScale = 0;
            Debug.Log("Game Won");
        }

    }
}
