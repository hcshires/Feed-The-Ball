using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelMenuButtons : MonoBehaviour
{

    public Button Level1;
    public Button Level2;
    public Button Level3;
    public Button Level4;
    public Button Level5;
    public Button BackBtn;

    // Use this for initialization
    void Start()
    {
        Button btn1 = Level1.GetComponent<Button>();
        Button btn2 = Level2.GetComponent<Button>();
        Button btn3 = Level3.GetComponent<Button>();
        Button btn4 = Level4.GetComponent<Button>();
        Button btn5 = Level5.GetComponent<Button>();
        Button btnBack = BackBtn.GetComponent<Button>();

        btn1.onClick.AddListener(TaskOnClick1);
        btn2.onClick.AddListener(TaskOnClick2);
        btn3.onClick.AddListener(TaskOnClick3);
        btn4.onClick.AddListener(TaskOnClick4);
        btn5.onClick.AddListener(TaskOnClick5);
        btnBack.onClick.AddListener(TaskOnClick6);

    }

    // When Buttons Clicked
    void TaskOnClick1()
    {
        SceneManager.LoadScene("Level 1");
    }

    // When Settings Clicked
    void TaskOnClick2()
    {
        SceneManager.LoadScene("Level 2");
    }

    void TaskOnClick3()
    {
        SceneManager.LoadScene("Level 3");
    }

    void TaskOnClick4()
    {
        SceneManager.LoadScene("Level 4");
    }

    void TaskOnClick5()
    {
        SceneManager.LoadScene("Level 5");
    }
    
    void TaskOnClick6()
    {
        SceneManager.LoadScene("Main");
    }
}