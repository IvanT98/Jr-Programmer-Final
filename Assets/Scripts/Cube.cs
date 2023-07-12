using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    protected override void DisplayText() {
        GameManager.Instance.SetText("Cube clicked!");
    }
}
