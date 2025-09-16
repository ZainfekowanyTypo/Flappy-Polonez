using UnityEngine;

public class WindowSwich : MonoBehaviour
{
    public Animator animator;
    public AnimationClip slideToGeneral, slideToSettings;

    public void switchWindowToMainMenu()
    {
        animator.Play(slideToGeneral.name);
    }

    public void switchWindowToSettings() 
    {
        animator.Play(slideToSettings.name);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
