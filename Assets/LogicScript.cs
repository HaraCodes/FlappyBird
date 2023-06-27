using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{   
    public Text scoreText;
    public int score = 0;
    public bool isBirdAlive = true;
    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd){
        score = score + scoreToAdd;
        scoreText.text = score.ToString();
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
