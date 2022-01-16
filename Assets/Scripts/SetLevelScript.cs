using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SetLevelScript : MonoBehaviour
{
    public Text lvlText;
    public GameObject finishPanel;

    void Start()
    {
        if (finishPanel) finishPanel.SetActive(false);
        if (lvlText)
        {
            lvlText.text = $"Уровень: {SceneManager.GetActiveScene().buildIndex}";
        }
    }

    public void SetScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLeveL()
    {
        int nextIndexScene = SceneManager.GetActiveScene().buildIndex + 1;
        if (SceneManager.sceneCountInBuildSettings > nextIndexScene)
        {
            SceneManager.LoadScene(nextIndexScene);
        }
        else
        {
            finishPanel.SetActive(true);
        }
    }

    public void PlayerDied()
    {
        Invoke("RestartScene", 2);
    }
}
