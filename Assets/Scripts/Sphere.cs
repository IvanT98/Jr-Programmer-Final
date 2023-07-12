using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Sphere : Shape
{
    // POLYMORPHISM
    protected override void DisplayText() {
        GameManager.Instance.SetText("Sphere clicked!");
    }
}
