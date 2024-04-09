using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skip : MonoBehaviour
{
    public GameObject SkipButton;

    public void ActivateSkipButton()
    {
        SkipButton.SetActive(true);
    }
}
