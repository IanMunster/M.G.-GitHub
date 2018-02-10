using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class movementBloodController : MonoBehaviour {

    private DeterioratingVelocity _launch;
    private Gravity _gravity;
    private RandomSideVelocity _randomVelocity;

    private Vector3 _sideVelocity;

	// Use this for initialization
	void Start () {
        _launch = GetComponent<DeterioratingVelocity>();
        _gravity = GetComponent<Gravity>();
        _randomVelocity = GetComponent<RandomSideVelocity>();

        _sideVelocity = _randomVelocity.getRandomVelocity();

    }
	
	// Update is called once per frame
	void Update () {
        Vector3 velocity;
        velocity = _gravity.gravity + _launch.slowingVelocity + _sideVelocity;
        velocity *= Time.deltaTime;
        transform.position += velocity;
	}
}
