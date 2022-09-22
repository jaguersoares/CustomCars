using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOptions : MonoBehaviour
{
    // public void PlayGame()
    // {
    //     SceneManager.LoadScene(2);
    // }
    public GameObject loadingPanel;
    public static int selectedTrack = 1;
    public void PlayGame()
    {
        if (loadingPanel) loadingPanel.SetActive(true);
        StartCoroutine(LoadTrackSelection());
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    //Aqui abaixo ficam as seleções de pista
    public void Track01()
    {
        if (loadingPanel) loadingPanel.SetActive(true);
        StartCoroutine(LoadTrack01());
    }
    public void Track02()
    {
        if (loadingPanel) loadingPanel.SetActive(true);
        StartCoroutine(LoadTrack02());
    }

    public void Track03()
    {
        if (loadingPanel) loadingPanel.SetActive(true);
        StartCoroutine(LoadTrack03());
    }
    IEnumerator LoadTrackSelection()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(1);
    }
    IEnumerator LoadTrack01()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(4);
        selectedTrack = 1;
    }
    IEnumerator LoadTrack02()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(5);
        selectedTrack = 2;
    }
    IEnumerator LoadTrack03()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(6);
        selectedTrack = 3;
    }


    public void CreditsScene()
    {
        SceneManager.LoadScene(2);
    }
    public void EditorScene()
    {
        SceneManager.LoadScene(3);
    }
}
