using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuestPresenter : MonoBehaviour
{
    [SerializeField] Text StageText;
    [SerializeField] PlayerStatusView playerStatusView;

    int CurrenStage = 0;

    void Start()
    {
        StageText.text = string.Format("Stage:{0}", CurrenStage);
        playerStatusView.UpdateText(10, 100, 5);
    }

    public void OnNextButton()
    {
        CurrenStage++;
        StageText.text = string.Format("Stage:{0}", CurrenStage);
    }

    public void OnBackButton()
    {
        SceneManager.LoadScene("Town");
    }
}

