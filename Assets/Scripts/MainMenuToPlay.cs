using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MainMenuToPlay : MonoBehaviour
{
    public GameObject howtoPlayScreen;
    [SerializeField]
    private float WaitTime;
    public List<GameObject> screens;

    public EventSystem MainUI;

    public GameObject BackButton;
    public GameObject PlayButton;
    public GameObject ControlScreen;


    private void Start()
    {
        MainUI.SetSelectedGameObject(PlayButton);
        ResetScreens();
    }
    public void ResetScreens()
    {
        MainUI.SetSelectedGameObject(PlayButton);
        for (int i = 0; i < screens.Count; i++)
        {
            screens[i].SetActive(false);
        }
        ControlScreen.SetActive(false);
    }
    public void Onplay()
    {
        StartCoroutine(Tutorial());
    }
    public void ToControls()
    {
        //ResetScreens();
        ControlScreen.SetActive(true);
        MainUI.SetSelectedGameObject(BackButton);
    }
    public void OnExit()
    {
        Application.Quit();
    }

    public void ToGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public IEnumerator Tutorial()
    {
        for(int i = 0; i <= screens.Count - 1; i++)
        {
            screens[i].SetActive(true);
            yield return new WaitForSeconds(WaitTime);
            screens[i].SetActive(false);
        }
        screens[4].SetActive(true);
        yield return new WaitForSeconds(WaitTime);
        ToGame();

        //TutAgainButton.SetActive(true);
        //BackButton.SetActive(false);
    }
}
 