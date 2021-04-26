using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelAndDifficulty : MonoBehaviour
{
    public string sceneName;
    public KeyCode keyCode;

    GameObject player;

    private bool inTouch = false;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update() {
        if (inTouch && keyCode != KeyCode.None && Input.GetKeyDown(keyCode)) {
            LoadLevel();
            player.GetComponent<sis_health>().dificuldade++;
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

