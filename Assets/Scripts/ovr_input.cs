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
        if (OVRInput.Get(OVRInput.Button.SecondaryHandTrigger))
        {
            //cube.GetComponent<cube_physics>().Angle = new Vector3(3, 3, 3);
            SceneManager.LoadScene("menu");
        }

    }
}
