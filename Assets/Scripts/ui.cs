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
    // Start is called before the first frame update
    void Start()
    {
        dialogbox.enabled = false;
        radius = 3f;
        counter = 1;
        button1 = GameObject.Find("Canvas/ui/Button1");
        button1.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("Humanoid");
        female = GameObject.Find("cuban_female2_Unity");
        distance = (female.transform.position - player.transform.position).sqrMagnitude;
        if (distance < radius)
        {
            dialogbox.enabled = true;
            chat.text = "Hello!";
            button1.SetActive(true);
            buttonText.text = "How are you?";
           
        }
        else
        {
            dialogbox.enabled = false;
            chat.text = "";
            button1.SetActive(false);
        }
    }
    public void buttonController()
    {
        if (counter == 1)
        {
            chat.text = "I'm fine! Thank you!";
            buttonText.text = "Bye!";
            counter++;
        }
        else if (counter == 2)
        {
            chat.text = "";
            button1.SetActive(false);
        }
    }
}
