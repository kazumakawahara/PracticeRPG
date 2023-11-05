using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatusView : MonoBehaviour
{
    [SerializeField] Text hpTaxt;
    [SerializeField] Text atText;

    public void UpdateText(PlayerModel playerModel)
    {
        hpTaxt.text = string.Format("HP : {0}/{1}", playerModel.HP, playerModel.MaxHP);
        atText.text = string.Format("AT : {0}", playerModel.AT);
    }
}
