using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIDisplay : MonoBehaviour
{
    [Header("Score")]
    [SerializeField] TextMeshProUGUI scoreText;
    ScoreKeeper scoreKeeper;
    [Header("Health")]
    [SerializeField] Slider healthbar;
    [SerializeField] HealthScript playerHealth;


    void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }
    void Start()
    {
        GetScore();
        healthbar.maxValue = playerHealth.GetHealth();
    }

    public void GetScore()
    {
        scoreText.text = scoreKeeper.GetCurrentScore().ToString("000000000");
    }

    public void GetPlayerHealth()
    {
        healthbar.value = playerHealth.GetHealth();
    }

    void Update()
    {

    }
}
