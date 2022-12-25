using UnityEngine;

[System.Serializable]
public struct CharacterInfo
{
    public string name;
    public int HP;
    public int maxHP;

    public CharacterInfoPanelUI panelUI;

    public void Init()
    {
        panelUI.SetName(name);
        panelUI.SetHealth(HP, maxHP);
    }

    public void TakeDamage(int dmg)
    {
        HP = Mathf.Max(0, HP - dmg);
        panelUI.SetHealth(HP, maxHP);
    }

    public void Heal(int dmg)
    {
        HP = Mathf.Min(maxHP, HP + dmg);
        panelUI.SetHealth(HP, maxHP);
    }
}
