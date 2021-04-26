using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelByName : MonoBehaviour
{
    public string sceneName;
    public KeyCode keyCode;

    private bool inTouch = false;

    private void Update() {
        if (inTouch && keyCode != KeyCode.None && Input.GetKeyDown(keyCode)) {
            SceneManager.LoadScene(sceneName);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            inTouch = true;
            if (keyCode == KeyCode.None) {
                SceneManager.LoadScene(sceneName);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (other.tag == "Player") {
            inTouch = false;
        }
    }
}
