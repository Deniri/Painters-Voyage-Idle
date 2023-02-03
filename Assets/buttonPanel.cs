using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonPanel : MonoBehaviour
{
    public GameObject panel;

    private void OnMouseUpAsButton()
    {
        panel.SetActive(true);
    }
}
