using UnityEngine;

public class Animator : MonoBehaviour
{
    Animator PlayerAnimator;
    private void Start()
    {
        PlayerAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        PlayerAnimator.SendMessage("Anan");
    }
}
