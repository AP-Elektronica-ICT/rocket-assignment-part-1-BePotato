using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MyGameManager : MonoBehaviour
{
    public GameObject Player;
    public GameObject MainCanvas;
    public GameObject GameOverCanvas;
    public GameObject Platform;
    public GameObject Coin;
    private Health healthPlayer;
    private EndPlatform endPlatform;
    private Coin coin;
    public string mLevelToLoad1;
    public string mLevelToLoad2;
    public Text Text;
    public int Score = 0;
    public enum GameStates 
    { 
        Playing,
        GameOver
    }
    public enum GameLevel
    {
        Level1,
        Level2
    }
    public GameStates gameState = GameStates.Playing;
    public GameLevel gameLevel = GameLevel.Level1;
    // Start is called before the first frame update
    void Start()
    {
        if (Player == null)
        {
            Player = GameObject.FindWithTag("Player");
        }
        if (Platform == null)
        {
            Platform = GameObject.FindWithTag("Finish");
        }
        if (Coin == null)
        {
            Coin = GameObject.FindWithTag("Coin");
        }
        healthPlayer = Player.GetComponent<Health>();
        endPlatform = Platform.GetComponent<EndPlatform>();
        coin = Coin.GetComponent<Coin>();
    }

    // Update is called once per frame
    void Update()
    {
        //State Machine of the game
        switch (gameState)
        {
            case GameStates.Playing:
                if (healthPlayer.isAlive == false)
                {
                    gameState = GameStates.GameOver;
                    MainCanvas.SetActive(false);
                    GameOverCanvas.SetActive(true);
                }
                Text.text = "Score: " + Score;
                break;
           
        }
        switch (gameLevel)
        {
            case GameLevel.Level1:
                if (endPlatform.LandedOnPlatform == true)
                {
                    gameLevel = GameLevel.Level2;
                    SceneManager.LoadScene(mLevelToLoad2);
                }
                break;
            case GameLevel.Level2:
                if (endPlatform.LandedOnPlatform == true)
                {
                    gameLevel = GameLevel.Level1;
                    SceneManager.LoadScene(mLevelToLoad1);
                }
                break;
        }
    }
}
