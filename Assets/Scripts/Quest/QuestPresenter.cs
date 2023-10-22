using UnityEngine;
using UnityEngine.SceneManagement;

public class QuestPresenter : MonoBehaviour
{
    public void OnBackButton()
    {
        SceneManager.LoadScene("Town");
    }
}

