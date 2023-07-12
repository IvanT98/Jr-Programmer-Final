using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour {
    public static GameManager Instance { get; private set; }

    [SerializeField]
    TextMeshProUGUI displayText;

    // ABSTRACTION
    public void SetText(string newText) {
        if (!displayText.gameObject.activeInHierarchy) {
            displayText.gameObject.SetActive(true);
        }

        displayText.SetText(newText);
    }

    // Start is called before the first frame update
    void Start() {
        Singleton();
    }

    void Singleton() {
        if (Instance != null) {
            Destroy(gameObject);

            return;
        }

        Instance = this;
    }
}
