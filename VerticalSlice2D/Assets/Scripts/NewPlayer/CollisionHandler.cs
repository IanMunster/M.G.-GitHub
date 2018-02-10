using UnityEngine;
using System.Collections;
/// <summary>
/// Collision handler.
/// </summary>
public class CollisionHandler : MonoBehaviour {

	[SerializeField] private string[] _ignore;
	[SerializeField] private string[] _collides;
	private bool _isColliding;
	private GameObject _collidingGameObject;

	public bool getIsColliding{
		get{ return _isColliding; }
	}
	public GameObject getCollidingGameobject{
		get{ return _collidingGameObject; }
	}
	public string[] getColliderTags{
		get{
			return _collides;
		}
	}

	void Update(){
		print (_collidingGameObject);
	}

	void OnTriggerEnter(Collider other){
		for (int i = 0; i < _collides.Length; i++) {
			if(other.CompareTag(_collides[i])){
				_isColliding = true;
				_collidingGameObject = other.gameObject;
			}
		}
		for (int i = 0; i < _ignore.Length; i++) {
			if(other.CompareTag(_ignore[i])){
				_isColliding = false;
			}
		}
	}
	void OnCollisionEnter(Collision other){
		for (int i = 0; i < _collides.Length; i++) {
			if(other.gameObject.CompareTag(_collides[i])){
				_isColliding = true;
				_collidingGameObject = other.gameObject;
			}
		}
		for (int i = 0; i < _ignore.Length; i++) {
			if(other.gameObject.CompareTag(_ignore[i])){
				_isColliding = false;
			}
		}
	}

	void OnCollisionExit(){
		_collidingGameObject = null;
		_isColliding = false;
	}
	void OnTriggerExit(){
		_collidingGameObject = null;
		_isColliding = false;
	}
}
