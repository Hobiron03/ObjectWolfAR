
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{
    public GameObject selectHowToPlayUI;
    public GameObject fadePanelCanvas;
    public GameObject fadePanel;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PushPlayButton()
    {
        selectHowToPlayUI.SetActive(true);
    }

    public void CloseSelectHowToPlayUI()
    {
        selectHowToPlayUI.SetActive(false);
    }


    #region SceneTransition

    public void FadeOutScreen(string destination)
    {
        fadePanelCanvas.SetActive(true);
        Image fadePanelImage = fadePanel.GetComponent<Image>();

        DOTween.ToAlpha(
            () => fadePanelImage.color,
            color => fadePanelImage.color = color,
            1.0f,
            0.3f
        );

        // SceneManager.LoadScene(destination);
    }

    //一つの端末でプレイ
    public void GoToOnePhoneGameScreen()
    {
        FadeOutScreen("OnePhoneGame");
    }

    public void GoToMultiPhoneGameScreen()
    {
        SceneManager.LoadScene("OnePhoneGame");
    }

    public void GoToMuseum()
    {
        SceneManager.LoadScene("Museum");
    }

    #endregion
}
