using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuestPresenter : MonoBehaviour
{
    [SerializeField] Text StageText;

    int CurrenStage = 0;

    void Start()
    {
        StageText.text = string.Format("Stage:{0}", CurrenStage);
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

