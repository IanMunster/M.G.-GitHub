using UnityEngine;
using System.Collections;

public class enemyShooting : MonoBehaviour {

    [SerializeField] private GameObject _projectile;
    [SerializeField] private float _time;
    [SerializeField] private float _chance;

    void Start()
    {
        //SetRandomTime();
        
        StartCoroutine(Shoot());
    }

    /*private void SetRandomTime()
    {
        _randomTimeMax = Mathf.Abs(_randomTimeMax);
        _randomTimeMin = Mathf.Abs(_randomTimeMin);
        if(_randomTimeMin > _randomTimeMax)
        {
            float temp = _randomTimeMax;
            _randomTimeMax = _randomTimeMin;
            _randomTimeMin = temp;
        }
    }*/

    private IEnumerator Shoot()
    {
        while (true)
        {
            float random = Random.Range(0, _chance);
            random = Mathf.Round(random);
            print(random);
            if(random == 1)
            {
                GameObject projectile;
                projectile = Instantiate(_projectile);
                projectile.transform.position = this.transform.position;
                
            }
            yield return new WaitForSeconds(_time);

        }
    }
}
