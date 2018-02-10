using UnityEngine;
using System.Collections;

public class ProjectileDestroyScript : MonoBehaviour {
	
	[SerializeField] private string _ignoreCollider;
	private Animator _animator;

	void Start(){
		_animator = GetComponent<Animator> ();
	}

    void OnTriggerEnter(Collider other)
    {
		//Do not stop if collides with Ignored Objects or if there is no given Ignore string
		if (!other.CompareTag (_ignoreCollider)) {
			_animator.SetTrigger ("Hit");
			StartCoroutine ("WaitaSec");
		} else {
			return;
		}
    }

	IEnumerator WaitaSec(){
		yield return new WaitForSeconds (1f);
		Destroy (this);
		this.gameObject.SetActive (false);
		StopCoroutine ("WaitaSec");
	}
}
