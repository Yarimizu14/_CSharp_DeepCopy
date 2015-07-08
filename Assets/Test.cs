using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{
    // Use this for initialization
    void Start () {

        //this.ExecuteSample2();
        this.ExecuteSample3();

    }

    void ExecuteSample1()
    {
        CopySample sample = new CopySample();
        sample.field1 = 10;
        CopySample copied = sample.DeepCopy();

        Debug.Log(sample);
        Debug.Log(copied);

        copied.field1 = 100;

        Debug.Log(sample);
        Debug.Log(copied);
    }

    void ExecuteSample2()
    {
        CopySample2 sample = new CopySample2();
        sample.field1 = 10;
        sample.field2 = 15f;

        CopySample2 copied = sample.DeepCopy();

        Debug.Log(sample);
        Debug.Log(copied);

        copied.field1 = 100;
        copied.field2 = 30f;

        Debug.Log(sample);
        Debug.Log(copied);
    }

    void ExecuteSample3()
    {
        CopySample3 sample = new CopySample3();
        sample.field1 = 10;
        sample.field2 = 15f;
        sample.field3 = new CopySample();
        sample.field3.field1 = 123;

        CopySample3 copied = sample.DeepCopy();

        Debug.Log("Copied!!!!!");

        Debug.Log(sample);
        Debug.Log(copied);

        copied.field1 = 100;
        copied.field2 = 30f;
        sample.field3.field1 = 321;

        Debug.Log("Value Changed!!!!!");

        Debug.Log(sample);
        Debug.Log(copied);
    }

    // Update is called once per frame
    void Update () {
    }
}
