using UnityEngine;
using System.Collections;

/// <summary>
/// holds the component that instantiate a projectile
/// (base is ObjectHolder)
/// </summary>
public class TriggerComponentHolder : ObjectHolder {

    private Shoot[] _triggers;//array in which the shoot components will be placed

    public Shoot[] triggers
    {
        get { return _triggers; }
    }

	// Use this for initialization
	void Start () {
        _triggers = new Shoot[objects.Length];//makes new array.
        for (int i = 0; i < objects.Length; i++)
        {
            _triggers[i] = objects[i].GetComponent<Shoot>();//extracts all the "Shoot" classes and puts them in an array
        }
    }
	
}
