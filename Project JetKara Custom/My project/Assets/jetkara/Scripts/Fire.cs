using UnityEngine;


public class Fire : MonoBehaviour
{
	float _timefire;
	float _timelight;

	void OnEnable () 
	{
		_timefire = Time.time + 0.3f;
		_timelight = Time.time + 0.4f;
	}
	
	void FixedUpdate () 
	{
		if (gameObject.name == "rocket1")
		{
			if (_timefire < Time.time)
				gameObject.SetActive(false);
		}
		else if (gameObject.name == "rocket2")
        {
			if (_timelight < Time.time)
				gameObject.SetActive(false);
		}

	}
}
