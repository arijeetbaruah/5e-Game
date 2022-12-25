using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterInfoPanelUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI characterNameTxt;
    [SerializeField]
    private TextMeshProUGUI characterHealthUI;
    [SerializeField]
    private Image healthBar;

    public void SetHealth(int currentHP, int maxHP)
    {
        characterHealthUI.SetText($"{currentHP}/{maxHP}");
        float health = (float)currentHP / (float)maxHP;
        Debug.Log(health);
        healthBar.fillAmount = health;
    }

    public void SetName(string characterName)
    {
        characterNameTxt.SetText(characterName);
    }
}
