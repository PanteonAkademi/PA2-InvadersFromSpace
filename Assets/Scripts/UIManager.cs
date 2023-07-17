using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    private static UIManager instance;

    public TextMeshProUGUI scoreText;
    private int score;
    public TextMeshProUGUI highscoreText;
    private int highscore;
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI waveText;
    private int wave;
    public Image[] lifeSprites;
    public Image healtBar;
    public Sprite[] healthBars;
    private Color32 active = new Color(1, 1, 1, 1);
    private Color32 inactive = new Color(1, 1, 1, 0.25f);

    private void Awake()
    {
        if (instance == null) 
        { 
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static void UpdateLives(int l)
    {

    }

    public static void UpdateScore (int l)
    {

    }

    public static void UpdateHighScore()
    {

    }

    public static void UpdateWave()
    {

    }

    public static void UpdateCoins()
    {

    }

}
