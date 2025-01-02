using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class LoopSamples : MonoBehaviour
{
    int number = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //while (number < 5)
        //{
        //    number++;
        //    Debug.Log(number);
        //}
        //for (int i = 0; i < 5; i++)
        //{
        //    Debug.Log(number);
        //}
        do
        {
            number++;
            Debug.Log(number);
        } while (number<5);
        //// Update is called once per frame
        //void Update()
        //{

        //}

    }
}