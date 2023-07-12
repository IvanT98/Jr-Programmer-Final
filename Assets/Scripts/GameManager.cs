using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour {
    public static GameManager Instance { get; private set; }

    [SerializeField]
    TextMeshProUGUI displayText;

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

    // Update is called once per frame
    void Update() {

    }


    void Singleton() {
        if (Instance != null) {
            Destroy(gameObject);

            return;
        }

        Instance = this;
    }
}
