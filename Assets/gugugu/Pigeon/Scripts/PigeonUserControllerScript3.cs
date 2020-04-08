using UnityEngine;
using System.Collections;

public class PigeonUserControllerScript3 : MonoBehaviour {
	public PigeonCharacterScript3 pigeonCharacter;
	public GameObject player;
	public float distance;
	void Start () {
		pigeonCharacter = GetComponent<PigeonCharacterScript3> ();
		player = GameObject.Find("Humanoid");
	}
	
	void Update(){
		distance = (transform.position - player.transform.position).sqrMagnitude;
		if (Input.GetKeyDown(KeyCode.L)) {
			pigeonCharacter.Landing();
		}
		
		if (distance < 5f) {
			Vector3 direction = transform.position - player.transform.position;
			Quaternion rotation = Quaternion.LookRotation(direction);
			transform.rotation = rotation;
			pigeonCharacter.Soar ();
			transform.position = transform.position + new Vector3(1f, 0, 0) * Time.deltaTime;
		}
		
		if (Input.GetKeyDown(KeyCode.E)) {
			pigeonCharacter.Eat();
		}

		if (distance < 15f)
		{
			Vector3 direction = transform.position - player.transform.position;
			Quaternion rotation = Quaternion.LookRotation(direction);
			transform.rotation = rotation;
			pigeonCharacter.Hop();
		}	
	}
	
	void FixedUpdate(){
		pigeonCharacter.SetForwardAcceleration(3f);
		pigeonCharacter.turnSpeed=1.5f;
		
	}
	
}
