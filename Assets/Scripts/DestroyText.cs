using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DestroyText : MonoBehaviour
{
    [SerializeField] GameObject objectToDestroy;
    [SerializeField] GameObject objectToCreate;

    public void LoadNewTextBox()
    {
        objectToDestroy.SetActive(false);
        objectToCreate.SetActive(true);
    }
}
