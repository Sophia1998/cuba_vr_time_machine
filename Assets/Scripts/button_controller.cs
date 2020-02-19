using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button_controller : MonoBehaviour
{
    // Start is called before the first frame update
  public void switchToScenePub()
    {
        SceneManager.LoadScene(3);
    }

    public void switchToSceneBeach()
    {
        SceneManager.LoadScene(4);
    }

    public void switchToSceneSquare()
    {
        SceneManager.LoadScene(5);
    }
    public void switchToSceneLobby()
    {
        SceneManager.LoadScene(0);
    }
}
