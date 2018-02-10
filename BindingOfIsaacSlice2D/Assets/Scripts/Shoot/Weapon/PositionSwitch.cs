using UnityEngine;
using System.Collections;

/// <summary>
/// sets the position of the gameobject to one of the positions saved in this position
/// (needs to only hold positions, will change later)
/// also should work with lists
/// </summary>
public class PositionSwitch : MonoBehaviour {


    [SerializeField] private Vector3[] _positions;

    /// <summary>
    /// Switches the current position the the one of the saved position.
    /// </summary>
    /// <param name="positionNum">the number of the position</param>
    public void SwitchPosition(int positionNum)
    {
        Vector3 position;
        position = _positions[positionNum];

        this.transform.localPosition = position;
    }

    /// <summary>
    /// Sets the first position.
    /// </summary>
    /// <param name="pos">Positin 1</param>
    public void SetPositionOne(Vector3 pos)
    {
        _positions[0] = pos;
    }
    /// <summary>
    /// Sets the second position
    /// </summary>
    /// <param name="pos">position 2</param>
    public void SetPositionTwo(Vector3 pos)
    {
        _positions[1] = pos;
    }
}
