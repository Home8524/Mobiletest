using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SceneChanger2 : MonoBehaviour, IPointerDownHandler,IPointerUpHandler
{
    void Start()
    {
        if (gameObject.transform.name != "Back")
        {
            Screen.orientation = ScreenOrientation.LandscapeLeft;
            Screen.autorotateToPortrait = false;
            Screen.autorotateToPortraitUpsideDown = false;
            Screen.autorotateToLandscapeLeft = true;
            Screen.autorotateToLandscapeRight = true;
        }
        else
        {
            Screen.orientation = ScreenOrientation.Portrait;
            Screen.autorotateToPortrait = true;
            Screen.autorotateToPortraitUpsideDown = false;
            Screen.autorotateToLandscapeLeft = false;
            Screen.autorotateToLandscapeRight = false;
        }
    }
    public void OnPointerDown(PointerEventData data)
    {
    }

    public void OnPointerUp(PointerEventData data)
    {
        if (gameObject.transform.name != "Back")
            SceneManager.LoadScene("Ability");
        else
            SceneManager.LoadScene("Lobby");
    }
}
