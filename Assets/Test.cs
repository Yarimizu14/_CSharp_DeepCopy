using UnityEngine;
using System.Collections;
using UniRx;

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
        sample.field4 = new ReactiveProperty<int>();
        sample.field4.Value = 1;

        sample.field4.Subscribe((int i) => { Debug.Log("field4 is observed : " + i); });

        CopySample3 copied = sample.DeepCopy();

        Debug.Log("Copied!!!!!");

        Debug.Log(sample);
        Debug.Log(copied);

        copied.field1 = 100;
        copied.field2 = 30f;
        copied.field4.Value = 11;
        sample.field3.field1 = 321;

        Debug.Log("Value Changed!!!!!");

        Debug.Log(sample);
        Debug.Log(copied);
    }

    // Update is called once per frame
    void Update () {
    }
}
