using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class human_ctrl : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 human_pos = transform.position;
        if (human_pos.x >= -10.5f && human_pos.x <= -9.5f && human_pos.z >= 0f)
        {

            SceneManager.LoadScene("capitol");

        }

    }
}
