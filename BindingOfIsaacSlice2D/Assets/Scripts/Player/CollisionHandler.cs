using UnityEngine;
using System.Collections;
/// <summary>
/// Collision handler.
/// This Class is responsible for Collision Detection. In the inspector are two StringArrays, wich you can set the Tag of a gameobject to Ignore or Collide with.
/// </summary>
public class CollisionHandler : MonoBehaviour {

	[SerializeField] private string[] collisionTag;				//The String Array for Tags
	private bool _isColliding;								//Boolean when Colliding = true or false
	private GameObject _collidingGameObject;				//The GameObject with wich you Collide

	public bool getIsColliding{								//Get the Current value of IsColliding (False or True)
		get{ return _isColliding; }							//Return the Boolean
	}
	public GameObject getCollidingGameobject{				//Get the Colliding GameObject
		get{ return _collidingGameObject; }					//Return the GameObject
	}
	public string[] ColliderTags{						//Get the Colliding-Tags String Array
		get{ return collisionTag; }							//Return the StringArray
		set{ collisionTag = value; }
	}

	void OnCollisionEnter(Collision other){					//When a GameObjeect Enters the CollisionBox of this GameObject
		for (int i = 0; i < collisionTag.Length; i++) {		//Check the whole length of the Collides Array
			if(other.gameObject.CompareTag(collisionTag[i])){	//Compare if the Colliding GameObject tag is in the Array
				_isColliding = true;						//This GameObject is Colliding
				_collidingGameObject = other.gameObject;	//Set the Other GameObject to the CollidingGameObject variable
			}
		}
		_isColliding = false;
	}

	void OnCollisionExit(){									//When a GameObject Exits the CollisionBox of this GameObject
		_collidingGameObject = null;						//Empty the Colliding GameObject variable
		_isColliding = false;								//Set Colliding to false
	}

}
