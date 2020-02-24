using UnityEngine;

public class ovr_input : MonoBehaviour
{
    GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.Find("Cube");
    }

    // Update is called once per frame
    void Update()
    {
        OVRInput.Update();
        OVRInput.FixedUpdate();
        if (OVRInput.Get(OVRInput.Button.SecondaryHandTrigger))
        {
            cube.GetComponent<cube_physics>().Angle = new Vector3(3, 3, 3);
        }

    }
}
