using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class NextSceneLoading : MonoBehaviour
{
    // 로딩 슬라이더
    public Slider loadingBar;

    // 로딩 텍스트
    public Text loadingText;

    // 씬 번호
    public int sceneNum = 2;

    void Start()
    {
        // 비동기 로딩 씬 코루틴 함수를 실행한다
        StartCoroutine(LoadNextScene(sceneNum)); 
    }

    // 비동기 로딩 씬 코루틴 함수
    IEnumerator LoadNextScene(int num)
    {
        // 비동기 씬 로드 시작 
        AsyncOperation ao = SceneManager.LoadSceneAsync(num);

        // 로드되는 씬의 모습을 화면에 보이지 않도록 한다
        ao.allowSceneActivation = false;

        // 로딩이 끝나서 전환되기 전까지 진행 결과를 표시한다
        while (!ao.isDone)
        {
            loadingBar.value = ao.progress;
            loadingText.text = (ao.progress * 100f).ToString() + "%";

            // 만일, 로딩 진행도가 90% 이상이라면, 씬을 화면에 보일 수 있도록 한다
            if (ao.progress >= 0.9f)
            {
                ao.allowSceneActivation = true;
            }

            // 다음 프레임으로 넘긴다
            yield return null;
          }
;   }

}
