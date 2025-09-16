using UnityEngine;

public class WindowSwich : MonoBehaviour
{
    public Animator animator;
    public AnimationClip slideToGeneral, slideToSettings;

    public GameObject[] swindows;

    public void switchWindowToMainMenu()
    {
        animator.Play(slideToGeneral.name);
    }

    public void switchWindowToSettings() 
    {
        animator.Play(slideToSettings.name);
    }

    public void switchSettingsWindow(int windowindex)
    {
        for (int i = 0; i < swindows.Length; i++) { swindows[i].SetActive(false); }
        swindows[windowindex].SetActive(true);
    }

    //s

}
