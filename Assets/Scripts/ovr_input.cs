using UnityEngine;
using UnityEngine.SceneManagement;

public class ovr_input : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        OVRInput.Update();
        OVRInput.FixedUpdate();
        if (OVRInput.Get(OVRInput.Button.One))
        {
            SceneManager.LoadScene("menu");
        }
    }
}
