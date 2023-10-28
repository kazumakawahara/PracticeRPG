using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuestPresenter : MonoBehaviour
{
    [SerializeField] Text StageText;
    [SerializeField] PlayerStatusView playerStatusView;

    PlayerModel playerModel;

    void Start()
    {
        playerModel = new PlayerModel();

        StageText.text = string.Format("Stage : {0}", playerModel.CurrenStage);
        playerStatusView.UpdateText(playerModel);
    }

    public void OnNextButton()
    {
        playerModel.NextStage();
        StageText.text = string.Format("Stage : {0}", playerModel.CurrenStage);
    }

    public void OnBackButton()
    {
        playerModel.BackToTown();
        SceneManager.LoadScene("Town");
    }
}

