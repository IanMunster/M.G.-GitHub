using UnityEngine;
using System.Collections;

public class Switch{


    private int _maxNum;
    private int _currentNum = 0;//which number is currently selected.

    public int currentNum//the current number
    {
        get { return _currentNum; }
        set
        {
            _currentNum = CheckNumber(value);
        }
    }

    public int maxNum
    {
        get { return _maxNum; }
        set { _maxNum = value; }
    }

    public Switch()
    {
        Debug.Log("test");
    }

    /// <summary>
    /// Checks if the given nuber is in the within range.
    /// </summary>
    /// <param name="value">Number to check.</param>
    /// <returns></returns>
    private int CheckNumber(int value)
    {
        if (value >= _maxNum)
        {
            return value % _maxNum;
        }
        else if (value < 0)
        {
            return _maxNum - 1;
        }
        else
        {
            return value;
        }
    }

    /// <summary>
    /// Selects the next number.
    /// </summary>
    public void NextNum()
    {
        _currentNum++;
        _currentNum = CheckNumber(_currentNum);
    }
    /// <summary>
    /// Selects the previous number.
    /// </summary>
    public void PrevNum()
    {
        _currentNum--;
        _currentNum = CheckNumber(_currentNum);
    }
}
