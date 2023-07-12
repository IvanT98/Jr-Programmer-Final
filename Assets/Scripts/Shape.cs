using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    protected virtual void DisplayText() {
        GameManager.Instance.SetText("Shape clicked!");
    }

    // Start is called before the first frame update
    void Start()
    {
        
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
