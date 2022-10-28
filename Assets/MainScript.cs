using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using Random = UnityEngine.Random;

// class A
// {
//     public void Pouet()
//     {
//         var instance = new MainScript();
//
//         var method = instance.GetType().GetMethod("Start", BindingFlags.Instance | BindingFlags.NonPublic);
//
//         method.Invoke(instance, null);
//     }
// }


public class MainScript : MonoBehaviour
{
    public Transform[] cubesTransforms;
    
    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("Hello les 3A IABD 2 ! :) :) :)");
        
        Debug.Log($"Il y a {cubesTransforms.Length} composants dans mon tableau :)");

        ShufflePositions(cubesTransforms);
    }

    private static void ShufflePositions(Transform[] cubes)
    {
        for (var i = 0; i < cubes.Length; i++)
        {
            var rdmIdx = Random.Range(i, cubes.Length);
            
            (cubes[i].position, cubes[rdmIdx].position) = (cubes[rdmIdx].position, cubes[i].position);
        }
    }
}
