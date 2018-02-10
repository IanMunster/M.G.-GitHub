using UnityEngine;
using System.Collections;

public class RandomSideVelocity : MonoBehaviour {

    [SerializeField] private float _randomVelocityrange;
    
    public Vector3 getRandomVelocity()
    {
        return new Vector3(Random.Range(-_randomVelocityrange, _randomVelocityrange), 0, 0);
    }
    
}