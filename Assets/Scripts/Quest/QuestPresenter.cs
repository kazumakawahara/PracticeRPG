using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuestPresenter : MonoBehaviour
{
    [SerializeField] Text StageText;
    [SerializeField] PlayerStatusView playerStatusView;
    [SerializeField] StageView stageView;
    [SerializeField] GameObject menuView;

    PlayerModel playerModel;
    StageTableModel stageTableModel;

    void Start()
    {
        playerModel = new PlayerModel();
        stageTableModel = new StageTableModel();

        StageText.text = string.Format("Stage : {0}", playerModel.CurrenStage);
        playerStatusView.UpdateText(playerModel);
    }

    void SetupMonster()
    {
        menuView.SetActive(false);

        // モンスター生成
        MonsterModel monsterModel = stageTableModel.GetMonster(playerModel.CurrenStage);

        // モンスター描画
        stageView.SpawnMonster();

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
            SetupMonster();
        }
    }

    public void OnBackButton()
    {
        playerModel.BackToTown();
        SceneManager.LoadScene("Town");
    }
}

