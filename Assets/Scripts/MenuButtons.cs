using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuButtons : MonoBehaviour {

    public Button PlayButton;
    public Button SettingsButton;
    public Button LevelButton;

	// Use this for initialization
	void Start () {
       Button btnPlay = PlayButton.GetComponent<Button>();
       Button btnSettings = SettingsButton.GetComponent<Button>();
       Button btnLevels = LevelButton.GetComponent<Button>();

        btnPlay.onClick.AddListener(TaskOnClick1);
        btnSettings.onClick.AddListener(TaskOnClick2);
        btnLevels.onClick.AddListener(TaskOnClick3);
    }

    // When Play Clicked
    void TaskOnClick1 () {
        SceneManager.LoadScene("Level 1");
	}

    // When Settings Clicked
    void TaskOnClick2 ()
    {
        SceneManager.LoadScene("Settings");
    }

    void TaskOnClick3 ()
    {
        SceneManager.LoadScene("Level Menu");
    }
}
