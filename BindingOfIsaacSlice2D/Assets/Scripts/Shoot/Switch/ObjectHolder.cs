using UnityEngine;
using System.Collections;

/// <summary>
/// holds objects
/// </summary>
public class ObjectHolder : MonoBehaviour {

    [SerializeField] protected GameObject[] _objects;//array with objects

    public GameObject[] objects//returns all the objects
    {
        get { return _objects; }
    }
}
