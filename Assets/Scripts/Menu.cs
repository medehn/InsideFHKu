using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    void Start()
    {
        GetComponent<Canvas>().enabled = true;
        Time.timeScale = 0;

    }

    //to prevent flickering of menu, to react only first key
    private bool keyWasPressed = false;

    void Update()
    {

        //show/hide menu
        if (Input.GetAxisRaw("Menu") > 0f)
        {
            if (!keyWasPressed)
            {
                GetComponent<Canvas>().enabled = !GetComponent<Canvas>().enabled;
            }

            keyWasPressed = true;
        }
        else
        {
            keyWasPressed = false;
        }
    }

    //start Game with button, no savegame yet so just disabling the menu
    public void OnButtonStartPressed()
    {

        GetComponent<Canvas>().enabled = false;
     
    }

    public void OnButtonModelPressed()
    {
        SceneManager.LoadScene("ModelView");
    }

    public void OnButtonBackPressed()
    {

        SceneManager.LoadScene("InsideFHKufstein");

    }

}
