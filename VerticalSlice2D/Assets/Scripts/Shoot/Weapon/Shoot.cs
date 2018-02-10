using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

    [SerializeField] private GameObject _projectile;//the projectile which will be shot

    /// <summary>
    /// shoots a projectile
    /// </summary>
    /// <param name="layer">the rank in the layer</param>
    /// <param name="horizontalSpeed">the horizontal velocity</param>
    /// <param name="verticalSpeed">the vertical velocity</param>
    public void ShootWeapon(int layer,Vector2 dir)
    {
        GameObject projectile;
        projectile = Instantiate(_projectile);
        projectile.transform.position = this.transform.position;
        projectile.GetComponent<SpriteRenderer>().sortingOrder = layer;
        projectile.GetComponent<ProjectileMovement>().SetMovement(dir);
    }
}
