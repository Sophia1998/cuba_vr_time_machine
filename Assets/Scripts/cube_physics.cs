using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_physics : MonoBehaviour
{
    public Vector3 Angle;
    // Start is called before the first frame update
    void Start()
    {
        Angle = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(Angle);
    }
}
