using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public GameObject selectHowToPlayUI;

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

    public void GoToMuseum()
    {
        SceneManager.LoadScene("Museum");
    }

    #endregion
}
