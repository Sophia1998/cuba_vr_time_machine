using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class female : MonoBehaviour
{
    GameObject player;
    float distance;
    float radius;
    GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        radius = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("Humanoid");
        cube = GameObject.Find("Cube");
        distance = (transform.position - player.transform.position).sqrMagnitude;
        Debug.Log(distance);
        if(distance < radius)
        {
            cube.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }
    }
}
