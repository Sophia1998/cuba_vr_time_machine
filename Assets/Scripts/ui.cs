using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ui : MonoBehaviour

{
    public TextMeshProUGUI chat;
    [SerializeField] TextMeshProUGUI buttonText;
    public Button button;
    public int counter;
    public Image dialogbox;
    public GameObject button1;
    public GameObject player;
    public GameObject female;
    public float distance;
    public float radius;
    public bool firstReach;
    public bool ffirstReach;
    public AudioClip hi_clip;
    public float volume;
    AudioSource hi_src;
    // Start is called before the first frame update
    void Start()
    {
        dialogbox.enabled = false;
        radius = 3f;
        counter = 1;
        button1 = GameObject.Find("Canvas/ui/Button1");
        button1.SetActive(false);
        firstReach = false;
        ffirstReach = true;
        hi_src = GameObject.Find("cuban_female2_Unity").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        player = GameObject.Find("Humanoid");
        female = GameObject.Find("cuban_female2_Unity");
        distance = (female.transform.position - player.transform.position).sqrMagnitude;
        if (distance < radius && ffirstReach)
        {
            firstReach = true;
            ffirstReach = false;
        }
        if (firstReach)
        {
            dialogbox.enabled = true;
            chat.text = "Hi!!!!";
            hi_src.PlayOneShot(hi_clip,volume);
            button1.SetActive(true);
            buttonText.text = "Hi!";
            buttonController();
            firstReach = false;
        }
        else
        { 
            buttonController();
        }
    }
    public void buttonController()
    {
        if (OVRInput.GetDown(OVRInput.Button.Four) && counter == 1)
        {
            Destroy(GameObject.Find("Canvas"));
            //chat.text = "I'm fine! Thank you!";
            //buttonText.text = "Bye!";
            counter++;
        }
      /*  else if (OVRInput.GetDown(OVRInput.Button.Three) && counter == 2)
        {
            Destroy(GameObject.Find("Canvas"));
        }*/
    }
}
