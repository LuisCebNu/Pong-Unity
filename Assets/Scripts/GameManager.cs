using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int _playerScore;
    private int _computerScore;
    public Text computerScoreText;
    public Text playerScoreText;
    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;
    public AudioSource _point;

    private void Start()
    {
        _point = this.gameObject.GetComponent<AudioSource>();
    }
    public void PlayerScore()
    {
        _playerScore++;
        playerScoreText.text = _playerScore.ToString();
        _point.Play();
        resetRound();
    }

    public void ComputerScore()
    {
        _computerScore++;
        computerScoreText.text = _computerScore.ToString();
        _point.Play();
        resetRound();
    }

    private void resetRound()
    {
        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();
        ball.ResetPosition();
        ball.AddStartingFoce();
    }
}
