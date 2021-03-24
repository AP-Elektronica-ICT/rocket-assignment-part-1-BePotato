using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameManager : MonoBehaviour
{
    public GameObject Player;
    public GameObject MainCanvas;
    public GameObject GameOverCanvas;
    private Health healthPlayer;
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
        healthPlayer = Player.GetComponent<Health>();
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
                break;
           
        }
    }
}
