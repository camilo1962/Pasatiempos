using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Ball ball;

    public Paddle playerPaddle;
    public int playerScore { get; private set; }
    public Text playerScoreText;

    public Paddle computerPaddle;
    public int computerScore { get; private set; }
    public Text computerScoreText;

    public int maxScore = 2;

   
    private void Start()
    {
        NewGame();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            NewGame();
        }
    }

    public void NewGame()
    {
        SetPlayerScore(0);
        SetComputerScore(0);
        StartRound();
    }

    public void StartRound()
    {
        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();
        ball.ResetPosition();
        ball.AddStartingForce();
    }

    public void PlayerScores()
    {
        SetPlayerScore(playerScore + 1);
        StartRound();
        CheckVictoria();
    }

    public void ComputerScores()
    {
        SetComputerScore(computerScore + 1);
        StartRound();
        CheckVictoria();
    }

    private void SetPlayerScore(int score)
    {
        playerScore = score;
        playerScoreText.text = score.ToString();
    }

    private void SetComputerScore(int score)
    {
        computerScore = score;
        computerScoreText.text = score.ToString();
    }

    public void CheckVictoria()
    {
        if(playerScore >= maxScore)
        {
            SceneManager.LoadScene("Victoria");
        }
        if(computerScore >= maxScore)
        {
            SceneManager.LoadScene("Victoria");
        }
    }

}