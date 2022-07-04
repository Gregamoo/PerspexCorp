using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject interactNotification;
    public GameObject uiText1;
    public GameObject uiText2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NotifyPlayer()
    {
        interactNotification.SetActive(true);
    }

    public void DeNotifyPlayer()
    {
        interactNotification.SetActive(false);
        uiText1.SetActive(false);
        uiText2.SetActive(false);
    }
}
