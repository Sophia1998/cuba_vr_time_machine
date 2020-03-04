using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class female : MonoBehaviour
{
    Animator animator;
    GameObject player;
    float distance;
    float radius;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        radius = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("Humanoid");
        distance = (transform.position - player.transform.position).sqrMagnitude;
        Debug.Log(distance);

        if(distance < radius)
        {
            Vector3 direction = player.transform.position - transform.position;
            Quaternion rotation = Quaternion.LookRotation(direction);
            transform.rotation = rotation;
            animator.SetTrigger("greet");
        }
    }
}
