using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{
    void Start()
    {
        Boss lastboss = new Boss();

        lastboss.Attack();

        lastboss.Defence(3);

        int[] array = { 1, 2, 3, 4, 5 };

        for (int i = 0; i < 5; i++) {
            Debug.Log(array[i]);
        }
    }
    void Update()
    {

    }
}