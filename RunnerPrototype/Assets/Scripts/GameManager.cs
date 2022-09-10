using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Text _scoreText;
    public Text _hpText;
    public Text _gameTimerText;

    private int _score;
    public int _hp;
    private int _gameTimer;

    private void Awake()
    {
        instance = this;
    }
     
    void Start()
    {
        ResetScore();
        ResetHP();
        ResetGameTimer();
    }

    private void ResetScore()
    {
        _score = 0;
        _scoreText.text = "Score " + _score.ToString();
    }
    private void ResetHP()
    {
        _hp = 3;
        _hpText.text = "HP " + _hp.ToString();
    }

    public void IncreaseScore()
    {
        _score++;
        _scoreText.text = "Score " + _score.ToString();
    }
    private void ResetGameTimer()
    {
        _gameTimer = 0;
    }

    public void DecreaseHP()
    {
        _hp--;
        _hpText.text = "HP " + _hp.ToString();
    }
  /*  public string GetGameTimer()
    {
        return _gameTimer.ToString();
    }*/
}
