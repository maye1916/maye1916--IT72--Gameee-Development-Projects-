using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadData : MonoBehaviour
{
    public Text UserNameBox;
    // Start is called before the first frame update
    void Start()
    {
        UserNameBox.text = PlayerPrefs.GetString("Username");
    }

    public void clickReset()
    {
        PlayerPrefs.DeleteKey("Username");
        SceneManager.LoadScene("firstScene");
    }

}
