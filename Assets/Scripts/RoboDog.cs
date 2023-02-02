using UnityEngine;
using TMPro;

public class RoboDog : Dog
{
    private string roboBark = "Beep e = mc ^2 boop boop";

    [SerializeField] TMP_Text mathText;

    private void Update()
    {
        Calculate();
    }
    public override void Bark()
    {
        base.Bark();
        Debug.Log($" {gameObject.name} also says {roboBark}");
    }

    /// <summary>
    /// Calculates 2 + 2 and puts over robo dog!
    /// </summary>
    private void Calculate()
    {
        if (ReturnPressed())
        {
            mathText.text = "2 + 2 = 4";
        }
    }

    /// <summary>
    ///  Returns true/false based on whether the return/enter bar has been pressed
    /// </summary>
    /// <returns></returns>
    private bool ReturnPressed()
    {
        return Input.GetKeyDown(KeyCode.Return);
    }
}
