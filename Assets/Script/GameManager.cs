using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    [SerializeField]
    private GameObject GameOverMenu;
    public float restartDelay = 1f;
    public GameObject deleteScore;

    public void GameOver ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            deleteScore.SetActive(false);
            GameOverMenu.SetActive(true);
        }
    }
}