using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{

    public Button BackBtn;

    // Start is called before the first frame update
    void Start()
    {
        Button btnBack = BackBtn.GetComponent<Button>();

        btnBack.onClick.AddListener(TaskOnClick1);
    }

    // When Clicked
    void TaskOnClick1()
    {
        SceneManager.LoadScene("Main");
    }
}
