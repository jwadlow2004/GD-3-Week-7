using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameDevWithMarco.Singleton;
using UnityEngine.SocialPlatforms.Impl;

namespace GameDevWithMarco.Managers
{
    public class GameManager : Singleton<GameManager>
    {
        private int score;

        public int Score
        {
            get
            {
                return score;
            }
        }


        public void AddToScore(int numberToAdd)
        {
            score += numberToAdd;
            Debug.Log($"The current score is {score}");
        }

    }
}
