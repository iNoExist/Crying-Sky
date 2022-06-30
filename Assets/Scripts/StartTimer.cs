using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartTimer : MonoBehaviour
{
    public Text startText;
    public float startingTimer = 3f;
    private float currentTime = 0f;
    public GameObject startUI;
    public GameObject Player;
    public GameObject Slot;
    private bool loop = true;
    void Start()
    {
        startUI.SetActive(true);
        Slot.SetActive(false);
        Player.GetComponent<PlayerMovement>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        currentTime = startingTimer;
        startText.text = startingTimer.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1* Time.deltaTime;
        if ((currentTime <= 1) && loop)
        {
            startup();
            loop = false;
            return;
        }
        startText.text = currentTime.ToString("0");
    }

    public void startup()
    {
        currentTime = 1;
        startText.text = currentTime.ToString("0");
        Cursor.lockState = CursorLockMode.None;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        startUI.SetActive(false);
        Slot.SetActive(true);
        Player.GetComponent<PlayerMovement>().enabled = true;
    }
}
