using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelToggle : MonoBehaviour
{
    public GameObject popupPanel,selectVideoPanel, popupPanel1;

    // Start is called before the first frame update

    public void ConfirmV1()
    {
        SceneManager.LoadScene(2);

    }
    public void ConfirmV2()
    {
        SceneManager.LoadScene(3);

    }
    public void Cancel()
    {
        popupPanel.SetActive(false);
        popupPanel1.SetActive(false);
        selectVideoPanel.SetActive(true);
    }
    public void Popup1()
    {
        popupPanel.SetActive(true);
        popupPanel1.SetActive(false);
        selectVideoPanel.SetActive(false);
    }
    public void Popup2()
    {
        popupPanel.SetActive(false);
        popupPanel1.SetActive(true);
        selectVideoPanel.SetActive(false);
    }
}
