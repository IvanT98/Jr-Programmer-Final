using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cube : Shape
{
    // POLYMORPHISM
    protected override void DisplayText() {
        GameManager.Instance.SetText("Cube clicked!");
    }
}
