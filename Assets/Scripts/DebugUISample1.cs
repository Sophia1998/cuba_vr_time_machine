using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Show off all the Debug UI components.
public class DebugUISample1 : MonoBehaviour
{
    bool inMenu;
    private Text sliderText;

	void Start ()
    {
        DebugUIBuilder.instance.AddButton("Go to the Pub", switchToScenePub);
        DebugUIBuilder.instance.AddButton("Go to the Capitol", switchToSceneCapitol);
        DebugUIBuilder.instance.AddButton("Go to the Beach", switchToSceneBeach);
        DebugUIBuilder.instance.AddButton("Go to the Square", switchToSceneSquare);
        
        DebugUIBuilder.instance.Show();
        inMenu = true;
	}
    public void switchToScenePub()
    {
        SceneManager.LoadScene("pub");
    }

    public void switchToSceneBeach()
    {
        SceneManager.LoadScene("beach");
    }

    public void switchToSceneCapitol()
    {
        SceneManager.LoadScene("capitol");
    }
    public void switchToSceneSquare()
    {
        SceneManager.LoadScene("square");
    }

    void Update()
    {
        if(OVRInput.GetDown(OVRInput.Button.Two) || OVRInput.GetDown(OVRInput.Button.Start))
        {
            if (inMenu) DebugUIBuilder.instance.Hide();
            else DebugUIBuilder.instance.Show();
            inMenu = !inMenu;
        }
    }

}
