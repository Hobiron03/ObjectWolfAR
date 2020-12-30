
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public GameObject selectHowToPlayUI;
    public GameObject fadePanel;

    // Start is called before the first frame update
    void Start()
    {
        Image fadePanelImage = fadePanel.GetComponent<Image>();
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


        SceneManager.LoadScene(destination);
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
