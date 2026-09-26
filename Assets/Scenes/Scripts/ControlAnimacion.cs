using UnityEngine;

public class ControlAnimacion : MonoBehaviour
{
    public Animator animator;

    public void Activar()
    {
        animator.SetTrigger("ActivarAnimacion");
    }
}
