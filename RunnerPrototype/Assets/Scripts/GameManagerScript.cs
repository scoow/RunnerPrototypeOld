using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int _score;

    public void IncreaseScore()
    {
        _score++;
    }

    void Start()
    {
        _score = 0;
    }

}
