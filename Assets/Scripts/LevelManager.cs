using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public int score;
    public int taskScore;

    public UnityEvent<int> ScoreChangeEvent;

    public void AddScore(int addScore)
    {
        score = score + addScore;

        ScoreChangeEvent?.Invoke(score);
    }

    public int GetScore()
    {
        return score;    
    }
    
    public int GetTaskScore()
    {
        return taskScore;
    }
    public void LoadLevel(string namelevel)
    {
        SceneManager.LoadScene(namelevel);
    }

    public void LevelManagerWithScore()
    {
        if (score == taskScore)
        {
            LoadLevel("LevelList");
        }
    }
}
