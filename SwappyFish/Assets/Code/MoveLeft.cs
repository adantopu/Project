using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
	
	[SerializeField]
	private float _speed = 5f;

	[SerializeField]
	private bool _randomizeHeight = true;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * _speed);
		if(transform.position.x < -15)
		{
			if(_randomizeHeight)
			{
				float randomYposition = UnityEngine.Random.Range(-3,3);
				transform.position = new Vector3(15,randomYposition,transform.position.z);
			}
			else
			{
				transform.position = new Vector3(15,transform.position.y,transform.position.z);
			}
		}
    }
}
