using UnityEngine;

public class BonusCollector : MonoBehaviour
{
    public int countBonus=0;
    private UIScript uIScript;

    private void Awake()
    {
        uIScript = GetComponent<MainElements>().uIScript;
    }

    private void Update()
    {
        uIScript.UpdateScore(countBonus);
    }

    public void showFinishPanel()
    {
        uIScript.ShowFinishPanel(countBonus);
    }
}
