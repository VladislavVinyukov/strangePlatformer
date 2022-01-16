using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    [SerializeField] private GameObject deathPanel;
    [SerializeField] private GameObject scorePanel;
    [SerializeField] private GameObject finishPanel;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text levelScore;

    private void Awake()
    {
        deathPanel.SetActive(false);
        finishPanel.SetActive(false);
        scorePanel.SetActive(true);
    }
    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void UpdateScore(int countBonus)
    {
        scoreText.text = countBonus.ToString();
    }

    public void ShowDeathPanel()
    {
        deathPanel.SetActive(true);
        scorePanel.SetActive(false);
    }

    public void ShowFinishPanel(int levelScoreCount)
    {
        levelScore.text = levelScoreCount.ToString();
        scorePanel.SetActive(false);
        finishPanel.SetActive(true);

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
            SceneManager.LoadScene(0);
        }
    }
}
