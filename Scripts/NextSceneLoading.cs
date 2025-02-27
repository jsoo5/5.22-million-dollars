using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class NextSceneLoading : MonoBehaviour
{
    // �ε� �����̴�
    public Slider loadingBar;

    // �ε� �ؽ�Ʈ
    public Text loadingText;

    // �� ��ȣ
    public int sceneNum = 2;

    void Start()
    {
        // �񵿱� �ε� �� �ڷ�ƾ �Լ��� �����Ѵ�
        StartCoroutine(LoadNextScene(sceneNum)); 
    }

    // �񵿱� �ε� �� �ڷ�ƾ �Լ�
    IEnumerator LoadNextScene(int num)
    {
        // �񵿱� �� �ε� ���� 
        AsyncOperation ao = SceneManager.LoadSceneAsync(num);

        // �ε�Ǵ� ���� ����� ȭ�鿡 ������ �ʵ��� �Ѵ�
        ao.allowSceneActivation = false;

        // �ε��� ������ ��ȯ�Ǳ� ������ ���� ����� ǥ���Ѵ�
        while (!ao.isDone)
        {
            loadingBar.value = ao.progress;
            loadingText.text = (ao.progress * 100f).ToString() + "%";

            // ����, �ε� ���൵�� 90% �̻��̶��, ���� ȭ�鿡 ���� �� �ֵ��� �Ѵ�
            if (ao.progress >= 0.9f)
            {
                ao.allowSceneActivation = true;
            }

            // ���� ���������� �ѱ��
            yield return null;
          }
;   }

}
