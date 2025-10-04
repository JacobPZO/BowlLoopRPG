using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.InputSystem;

public class MenuController : MonoBehaviour
{
    public void onMenuButtonPress(InputAction.CallbackContext context)
    {
        if(!menuCanvas.activeSelf && PauseController.IsGamePaused)
        {
            return;
        }
        menuCanvas.SetActive(!menuCanvas.activeSelf);
        PauseController.SetPause(menuCanvas.activeSelf);
    }

    public GameObject menuCanvas;
    // Start is called before the first frame update
    void Start()
    {
        menuCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
