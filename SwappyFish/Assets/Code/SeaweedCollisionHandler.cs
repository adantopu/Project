using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeaweedCollisionHandler : MonoBehaviour
{
	private AudioSource collision;
	
	void Start()
   {
	   collision = GetComponent<AudioSource>();
	   
   }
	
    void OnTriggerEnter2D(Collider2D other)
	{
		//Debug.Log("Entered");
		SceneManager.LoadScene(0);
		
		//play the sound
		//collision.Play();
	}
}
