using UnityEngine;
using System.Collections;

public class ProjectileDestroyOnCollision : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D col)
       {
           Destroy(col.gameObject);
       }
    }

