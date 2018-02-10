using UnityEngine;
using System.Collections;

public class TriggerHandler : MonoBehaviour {

	[SerializeField] private string[] triggersTag;				//The String Array for Tags
	private bool _isTriggered;								//Boolean when Colliding = true or false
	private GameObject _triggerGameObject;

	public bool getIsTriggered{								//Get the Current value of IsColliding (False or True)
		get{ return _isTriggered; }							//Return the Boolean
	}
	public GameObject getTriggeringGameobject{				//Get the Colliding GameObject
		get{ return _triggerGameObject; }					//Return the GameObject
	}
	public string[] TriggerTags{						//Get the Colliding-Tags String Array
		get{ return triggersTag; }							//Return the StringArray
		set{ triggersTag = value; }
	}


	void OnTriggerEnter(Collider other){					//When a GameObject Enters the _trigger of this GameObject
		for (int i = 0; i < triggersTag.Length; i++) {		//Check the whole length of the Collides Array
			if(other.CompareTag(triggersTag[i])){			//Compare if the Colliding GameObject tag is in the Array
				_isTriggered = true;						//This GameObject is Colliding
				_triggerGameObject = other.gameObject;	//Set the Other GameObject to the CollidingGameObject variable
			}
		}
	}

	void OnTriggerExit(){									//When a GameObject Exits the _trigger of this GameObject
		_triggerGameObject = null;						//Empty the Colliding GameObject variable
		_isTriggered = false;								//Set Colliding to false
	}
}
