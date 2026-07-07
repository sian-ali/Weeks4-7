using UnityEngine;

public class Numbers : MonoBehaviour
{
    public float startValue;
    public float multiplier;
    public float iterations; //iteration is a posh word for "repeat this many times" ...
    public float divisor;    //the divisor is the number you divide by
   
    void Start()
    {
        float number = startValue;
        Debug.Log(number);
        for (int i = 0; i < iterations; i++)
        {
            Debug.Log(number);
            number *= multiplier;
        }

        number /= divisor;

        Debug.Log(number);
    }

}
