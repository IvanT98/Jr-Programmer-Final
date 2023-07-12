using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
    protected override void DisplayText() {
        GameManager.Instance.SetText("Cylinder clicked!");
    }
}
