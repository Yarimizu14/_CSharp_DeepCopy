using UnityEngine;
using System.Collections;
using System;
using UniRx;

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

    public ReactiveProperty<int> field4;

    public override string ToString()
    {
        string s = "field1 : " + this.field1 + " field2 : " + _field2;

        if (this.field3 != null)
        {
            s += " field3 : " + this.field3.ToString();
        } else {
            s += " field3 : null ";
        }

        if (this.field4 != null)
        {
            s += " field4 : " + this.field4.Value;
        } else {
            s += " field4 : null ";
        }

        return s;
    }
}
