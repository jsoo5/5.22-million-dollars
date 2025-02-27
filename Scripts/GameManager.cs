using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject option;
    public GameObject gameover;
    
    public enum GameState
    {
        Run,
        Pause,
        Gameover
    }

    public GameState gamestate;

    public void OpenOptionWindow()
    {
        // 게임 상태를 pause로 변경한다
        gamestate = GameState.Pause;

        // 시간을 멈춘다
        Time.timeScale = 0;   // 1일 때 1배속. 2일 때 2배속

        // 옵션 메뉴창을 활성화한다
        option.SetActive(true);
    }

    // 옵션 메뉴 끄기 (계속하기)
    public void CloseOptionWindow()
    {
        gamestate = GameState.Run;
        Time.timeScale = 1;
        option.SetActive(false);
    }

    // 현재 씬 다시 로드 (다시하기)
    public void GameRestart()
    {
        Time.timeScale = 1;
        // 현재 씬을 다시 로드한다
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GoHome()
    {
        SceneManager.LoadScene("LoadingToHome");
    }

    // 게임 종료하기
    public void GameQuit()
    {
        // 어플리케이션을 종료한다
        Debug.Log("Game Quit");
        Application.Quit();
    }

    public void ProMode()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("LoadingToNight");
    }
    public void NormalMode()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("LoadingToNoon");
    }


    IEnumerator GameOverShow()
    {
        if (gamestate == GameState.Gameover)
        {
            gameover.SetActive(true);
            yield return new WaitForSecondsRealtime(2.0f);

            SceneManager.LoadScene("LoadingToScore");
        }
    }

    private void Update()
    {
        StartCoroutine("GameOverShow");
    }
}

