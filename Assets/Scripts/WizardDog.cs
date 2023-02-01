using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardDog : Dog
{
    [SerializeField] private ParticleSystem magic;
    private void Update()
    {
        CastSpell();
    }

    /// <summary>
    /// Plays magic particles if the space bar is pressed 
    /// </summary>
    private void CastSpell()
    {
        if (SpaceBarPressed())
        {
            magic.Play();
        }
    }

    /// <summary>
    /// Returns true/false based on whether the space bar has been pressed
    /// </summary>
    /// <returns></returns>
    private bool SpaceBarPressed()
    {
        return Input.GetKeyDown(KeyCode.Space);
    }
}
