using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuestPresenter : MonoBehaviour
{
    [SerializeField] Text StageText;
    [SerializeField] PlayerStatusView playerStatusView;

    PlayerModel playerModel;
    StageTableModel stageTableModel;

    void Start()
    {
        playerModel = new PlayerModel();
        stageTableModel = new StageTableModel();

        StageText.text = string.Format("Stage : {0}", playerModel.CurrenStage);
        playerStatusView.UpdateText(playerModel);
    }

    public void OnNextButton()
    {
        playerModel.NextStage();
        StageText.text = string.Format("Stage : {0}", playerModel.CurrenStage);

        if (stageTableModel.HasGameCleared(playerModel.CurrenStage))
        {
            Debug.Log("クリア");
        }
        else if (stageTableModel.IsEnemyPointAt(playerModel.CurrenStage))
        {
            Debug.Log("敵の出現");
        }
    }

    public void OnBackButton()
    {
        playerModel.BackToTown();
        SceneManager.LoadScene("Town");
    }
}

