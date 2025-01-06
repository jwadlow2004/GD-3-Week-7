using GameDevWithMarco.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using GameDevWithMarco.Data;

namespace GameDevWithMarco.Managers
{
    public class UiManager : MonoBehaviour
    {
        [SerializeField] TMP_Text scoreText;
        [SerializeField] GlobalData globalData;
        public void UpdateScoreText()
        {
            if (globalData != null)
            {
                scoreText.text = $"<b>Score</b>:{globalData.Score}";

            }
            else
            {
                Debug.Log("NO GB ON UI");
            }
        
        }
    }
}
