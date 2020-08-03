using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControal : MonoBehaviour
{
    /// <summary>
    /// 切換場景
    /// </summary>
    private void ChangeScene()
    {
        SceneManager.LoadScene("遊戲場景");
    }
    /// <summary>
    /// 離開遊戲
    /// </summary>
   private void Quit()
    {
        Application.Quit();
    }

    public void DelayChangeScene()
    {
        Invoke("ChangeScene", 0.7f);
    }
    /// <summary>
    /// 延遲離開遊戲
    /// </summary>
    public void DelayQuitScene()
    {
        Invoke("Quit", 0.7f);
    }
}
