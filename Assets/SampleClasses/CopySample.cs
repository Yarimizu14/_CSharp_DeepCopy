using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class CopySample
{
    public int field1;

    public override string ToString()
    {
        return "" + this.field1;
    }
}
