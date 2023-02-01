using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    protected string bark = "Bark Bark!";
    public virtual void Start()
    {
        Bark();
    }

    public virtual void Bark()
    {
        // transform.name gets the name of the game object 
        Debug.Log($" {transform.name} goes {bark}");
    }
}
