using GameDevWithMarco.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace GameDevWithMarco.Managers
{
    public class UiManager : MonoBehaviour
    {
        [SerializeField] TMP_Text scoreText;

        public void UpdateScoreText()
        {
            scoreText.text = $"<b>Score</b>:{GameManager.Instance.Score}";
        }
    }
}
