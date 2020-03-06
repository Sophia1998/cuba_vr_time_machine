using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class gugugu : MonoBehaviour
{
    public Animator ani;
    public GameObject bird;
    public GameObject corn;
    public int random;
    public float walkspeed = 1f;
    public bool feeding;
    GameObject player;

    public float distance;
    public float timeleft;
    public bool familiar;
    // Start is called before the first frame update
    void Start()
    {
        feeding = false;
        familiar = false;
        corn = GameObject.Find("Huamnoid/corn");
        corn.SetActive(false);
        bird = GameObject.Find("Pigeon1");
        player = GameObject.Find("Humanoid");
        ani = bird.GetComponent<Animator>();
        timeleft = 3f;
}

    // Update is called once per frame
    void Update()
    {
        distance = (transform.position - player.transform.position).sqrMagnitude;
        Debug.Log(distance);
        //if too close and hasn't feed yet, hop away
        if (distance < 15f && familiar == false)
        {
            corn.SetActive(false);
            ani.SetBool("walkforward", false);
            ani.SetBool("walkleft", false);
            ani.SetBool("walkright", false);
            ani.SetBool("hop", true);
            transform.position = transform.position + new Vector3(0.005f, 0, 0)*Time.deltaTime;
            transform.Translate(new Vector3(0, 0, 0));
        }
        //for testing if choose to feed 
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            corn.SetActive(true);
            ani.SetBool("walkforward", false);
            ani.SetBool("walkleft", false);
            ani.SetBool("walkright", false);
            ani.SetBool("hop", false);
            ani.SetBool("feeding", true);
            feeding = true;
            familiar = true;
        }
        //randomly walk
        else
        {
            corn.SetActive(false);
            ani.SetBool("hop", false);
            random = Random.Range(1, 4);
            if (random == 1)
            {
                ani.SetBool("walkleft", true);
                transform.position = transform.position + new Vector3(-0.001f, 0, 0)*Time.deltaTime;
              //  transform.Rotate(new Vector3(0, 0.005f, 0));
            }
            else if (random == 2)
            {
                ani.SetBool("walkright", true);
                transform.position = transform.position + new Vector3(0.001f, 0, 0)*Time.deltaTime;
            }
            else if (random == 3)
            {
                ani.SetBool("walkforward", true);
                transform.position = transform.position + new Vector3(0, 0, 0.001f)*Time.deltaTime;
               // transform.Rotate(new Vector3(0, 0.005f, 0));
            }
        }
        //if feed, fly towards player and eat 
        if(feeding == true)
        {
            Vector3 direction = player.transform.position - transform.position;
            Quaternion rotation = Quaternion.LookRotation(direction);
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 0.1f*Time.deltaTime);

            if (distance < 5f)
            {
                transform.position = transform.position + new Vector3(0, 0, 0)*Time.deltaTime;
                ani.SetBool("feeding", false);
                feeding = false;
                ani.SetBool("land", true);

                //eat for 3 sec and walk away 
                timeleft -= Time.deltaTime;
                if (timeleft < 0)
                {
                    random = Random.Range(1, 4);
                    if (random == 1)
                    {
                        ani.SetBool("walkleft", true);
                        transform.position = transform.position + new Vector3(-0.001f, 0, 0) * Time.deltaTime;
                        //  transform.Rotate(new Vector3(0, 0.005f, 0));
                    }
                    else if (random == 2)
                    {
                        ani.SetBool("walkright", true);
                        transform.position = transform.position + new Vector3(0.001f, 0, 0) * Time.deltaTime;
                    }
                    else if (random == 3)
                    {
                        ani.SetBool("walkforward", true);
                        transform.position = transform.position + new Vector3(0, 0, 0.001f) * Time.deltaTime;
                        // transform.Rotate(new Vector3(0, 0.005f, 0));
                    }
                    ani.SetBool("land", false);
                }
                }
        }
    }
}
