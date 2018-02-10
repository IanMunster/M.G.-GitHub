using UnityEngine;
using System.Collections;

public class MethodRepeater : MonoBehaviour {

    [SerializeField] private float _delay;//the time before the method is invoked again
    [SerializeField] private string _method;//the method
    [SerializeField] private MonoBehaviour _methodholder;//the class that holds the method

    private bool _isActive;//if it is repeating or not
    public bool isActive
    {
        get { return _isActive; }
        set { _isActive = value; }
    }


    void Start () {
        StartCoroutine(Shoot());//starts the repeater coroutine
	}

    IEnumerator Shoot()
    {
        while (true)//always repeate the coroutine
        {
            while (!_isActive)//if repeating is not active
            {
                yield return null;//wait one frame
            }
            //else if repeating is active
            _methodholder.Invoke(_method,0);//invoke the method
            yield return new WaitForSeconds(_delay);//wait for the set delay time
        }

    }
}
