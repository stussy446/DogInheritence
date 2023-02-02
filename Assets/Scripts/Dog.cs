using UnityEngine;

public class Dog : MonoBehaviour
{
    // ** QUICK DEFINITIONS **
    // the protected keyword lets the children of a parent class use the protected member, so any child of Dog can use that "Bark Bark" string
    // the virtual keyword lets the children of a parent class override the functionality of the virtual method as needed, so if a Dog chil barks a little differently than most 
    // we can override the behavior as needed.
    // ** End **

    protected string bark = "Bark Bark!";

    public virtual void Start()
    {
        Bark();
    }

    /// <summary>
    /// Prints out the Dog's bark to the console along with its name
    /// </summary>
    public virtual void Bark()
    {
        Debug.Log($" {gameObject.name} goes {bark}");
    }
}
