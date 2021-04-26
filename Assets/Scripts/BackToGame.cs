using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackToGame : MonoBehaviour
{
    // Start is called before the first frame update
    public Button yourButton;
	GameObject player;

	void Start () {
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
		player = GameObject.FindGameObjectWithTag("Player");player = GameObject.FindGameObjectWithTag("Player");
	}

	void TaskOnClick(){
		SceneManager.LoadScene("Level0");
		player.transform.position = new Vector3 (-8.23f, 0.5f, 0f);
        print("Fui clicado");
		player.GetComponent<sis_health>().increase_health(100);
	}
}
