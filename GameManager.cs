using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public BallController ball;

    private int playerScore;

    private int enemyScore;


    public void EnemyScores()
    {
        enemyScore++;

        this.ball.ResetGame();
        Debug.Log(playerScore);
    }

    public void PlayerScores()
    {
        playerScore++;

        this.ball.ResetGame();
        Debug.Log(enemyScore);
    }

}
