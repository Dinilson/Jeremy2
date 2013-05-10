using UnityEngine;
using System.Collections;

public class PathMovement : MonoBehaviour {
	
	private float pathMovement;
	public float posEnd;
	public float posStart=0;
	InputMovement inputMovement;
	
	void Start () {
		inputMovement= GameObject.FindGameObjectWithTag("Player").GetComponent<InputMovement>();
	}
	
	void Update () {
		transform.Translate(0,0,-inputMovement.laneSpeed* Time.deltaTime);
		if(transform.position.z < posEnd){
			transform.position= new Vector3(0,0,posStart);	
		}
	}
}
