using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ExitGame : MonoBehaviour
{
    private void Update()
    {
        var keyboard = Keyboard.current;
        // Quick and dirty one-liner to quit game (eg use at the end of the battle)
        if (keyboard.escapeKey.wasPressedThisFrame)
        {
            Application.Quit();
        }

    }
}
