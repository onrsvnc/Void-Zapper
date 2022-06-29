using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int currentScore = 0;
    UIDisplay uIDisplay;
    static ScoreKeeper instance;


    void Awake()
    {
        ManageSingleton();
    }

    public int GetCurrentScore()
    {
        return currentScore;
    }

    public void ModifyScore(int value)
    {
        uIDisplay = FindObjectOfType<UIDisplay>();
        currentScore += value;
        Mathf.Clamp(currentScore, 0, int.MaxValue);
        uIDisplay.GetScore();
    }

    public void ResetScore()
    {
        currentScore = 0;
    }

    void ManageSingleton()
    {
        if(instance != null)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
