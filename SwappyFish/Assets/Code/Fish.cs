using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fish : MonoBehaviour
{
	
	[SerializeField]
	private float _upwardForceMultiplier = 100f;
	
	[SerializeField]
	private AudioClip _swimmingAudio;
	
	[SerializeField]
	private AudioClip _collisionAudio;
	
	private AudioSource _audioSource;
	
    // Start is called before the first frame update
    void Start()
    {
       _audioSource = GetComponent<AudioSource>();
	   if (_audioSource == null)
	   {
		   Debug.LogError("Audio for fish is null");
	   }
    }

    // Update is called once per frame
    void Update()
    {
        bool pressedFireButton = Input.GetButton("Fire1");
		if(pressedFireButton)
		{
			Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
			rigidbody.velocity = Vector3.zero;
			rigidbody.AddForce(Vector3.up * _upwardForceMultiplier);
			
			//play the sound
			_audioSource.clip = _swimmingAudio;
			_audioSource.Play();
		}
		
		if(transform.position.y > 6f || transform.position.y < -6f)
		{
			 //play the sound
			_audioSource.clip = _collisionAudio;
			_audioSource.Play();
			
			SceneManager.LoadScene(0);
		}
    }
}
