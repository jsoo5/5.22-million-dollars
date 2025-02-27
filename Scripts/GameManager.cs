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
        // ���� ���¸� pause�� �����Ѵ�
        gamestate = GameState.Pause;

        // �ð��� �����
        Time.timeScale = 0;   // 1�� �� 1���. 2�� �� 2���

        // �ɼ� �޴�â�� Ȱ��ȭ�Ѵ�
        option.SetActive(true);
    }

    // �ɼ� �޴� ���� (����ϱ�)
    public void CloseOptionWindow()
    {
        gamestate = GameState.Run;
        Time.timeScale = 1;
        option.SetActive(false);
    }

    // ���� �� �ٽ� �ε� (�ٽ��ϱ�)
    public void GameRestart()
    {
        Time.timeScale = 1;
        // ���� ���� �ٽ� �ε��Ѵ�
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GoHome()
    {
        SceneManager.LoadScene("LoadingToHome");
    }

    // ���� �����ϱ�
    public void GameQuit()
    {
        // ���ø����̼��� �����Ѵ�
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

