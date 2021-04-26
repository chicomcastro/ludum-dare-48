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
            LoadLevel();
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            inTouch = true;
            if (keyCode == KeyCode.None) {
                LoadLevel();
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (other.tag == "Player") {
            inTouch = false;
        }
    }

    public void LoadLevel() {
        Scene currentScene = SceneManager.GetActiveScene();
        GameObject.FindGameObjectWithTag("Player").GetComponent<LevelMemory>().SetLevelLoaded(currentScene.name[currentScene.name.Length - 1].ToString());
        SceneManager.LoadScene(sceneName);
    }
}
