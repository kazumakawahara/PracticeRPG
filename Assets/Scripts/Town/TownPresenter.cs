using UnityEngine;
using UnityEngine.SceneManagement;

public class TownPresenter : MonoBehaviour
{
    public void OnQuestButton()
    {
        SceneManager.LoadScene("Quest");
    }
    public void OnTitleButton()
    {
        SceneManager.LoadScene("Title");
    }
}
