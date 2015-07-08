using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class CopySample3
{
    public int field1;

    private float _field2;
    public float field2
    {
        get
        {
            return _field2;
        }
        set
        {
            _field2 = value;
        }
    }

    public CopySample field3;

    public override string ToString()
    {
        return "field1 : " + this.field1 + " field2 : " + _field2 + " field3 : " + this.field3.ToString();
    }
}
