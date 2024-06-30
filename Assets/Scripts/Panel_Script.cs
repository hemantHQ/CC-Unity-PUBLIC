using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Panel_Script : MonoBehaviour
{
    [SerializeField] GameObject start_panel;
    [SerializeField] GameObject pause_button;
    [SerializeField] GameObject pause_panel;
    [SerializeField] GameObject Score_Canvas;
    private void Start()
    {
        Time.timeScale = 0f;
        start_panel.SetActive(true);
        pause_button.SetActive(false);
        Score_Canvas.SetActive(false);
    }
    public void tap_tap()
    {
        start_panel.SetActive(false);
        pause_button.SetActive(true);
        Score_Canvas.SetActive(true);
        Time.timeScale = 1f;
    }
    public void pausepanel()
    {
        pause_button.SetActive(false);
        Time.timeScale=0f;
        pause_panel.SetActive(true);
    }
    public void resume()
    {
        pause_panel.SetActive(false);
        Time.timeScale = 1f;
        pause_button.SetActive(true);   
    }
    public void retry()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
    public void Exit()
    {
       Application.Quit();
    }
}
