using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class GameObjectTriggerEvent : UnityEvent<GameObject>
{
}

public class TriggerHandler : MonoBehaviour {

	public LayerMask RespondTo = ~0; 

	public GameObjectTriggerEvent TriggerEnter;
	public GameObjectTriggerEvent TriggerStay;
	public GameObjectTriggerEvent TriggerLeave;

	bool ShouldRespond(GameObject g)
	{
		return ((RespondTo & (1 << g.layer)) != 0);
	}

	void OnTriggerEnter(Collider c)
	{
		if (ShouldRespond(c.gameObject))
		{
			TriggerEnter.Invoke(c.gameObject);
		}
	}

	void OnTriggerStay(Collider c)
	{
		if (ShouldRespond(c.gameObject))
		{
			TriggerStay.Invoke(c.gameObject);
		}
	}

	void OnTriggerExit(Collider c)
	{
		if (ShouldRespond(c.gameObject))
		{
			TriggerLeave.Invoke(c.gameObject);
		}
	}
}
