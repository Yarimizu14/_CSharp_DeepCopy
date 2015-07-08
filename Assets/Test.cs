using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{
    // Use this for initialization
    void Start () {
        CopySample sample = new CopySample();
        sample.field1 = 10;
        CopySample copied = sample.DeepCopy();

        Debug.Log(sample);
        Debug.Log(copied);

        copied.field1 = 100;

        Debug.Log(sample);
        Debug.Log(copied);
    }

    // Update is called once per frame
    void Update () {
    }
}
