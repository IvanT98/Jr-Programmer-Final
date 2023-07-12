using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    [SerializeField]
    private string shapeName;

    public string ShapeName { get => shapeName; protected set => shapeName = value; }

    protected virtual void DisplayText() {
        GameManager.Instance.SetText("Shape clicked!");
    }

    // Update is called once per frame
    void Update()
    {
        CheckForClick();
    }

    void CheckForClick() {
        if (!Input.GetMouseButtonDown(0)) return;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (!Physics.Raycast(ray, out RaycastHit hit) || hit.transform == null || hit.transform.gameObject != gameObject) return;

        OnClick();
    }

    void OnClick() {
        DisplayText();
    }
}
