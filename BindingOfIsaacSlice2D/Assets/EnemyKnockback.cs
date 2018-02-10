
using UnityEngine;
using System.Collections;

public class EnemyKnockback : MonoBehaviour {
    [SerializeField] private float _force;

    [SerializeField] private float deterioration;

    private Rigidbody _rigid;
	private Vector3 velocity = new Vector3(0,0,0);

    public Vector3 vel
    {
        get { return velocity; }
		set {velocity = value;  }
    }

	// Use this for initialization
	void Start () {
        _rigid = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnTriggerEnter(Collider other)
    {
        //Check if its tag is marked as Deadly Object
        if (other.CompareTag("PlayerProjectile"))
        {
			print ("HIT");
			_rigid.AddForce (other.gameObject.GetComponent<ProjectileMovement>().Velocity);
        }

    }
}
