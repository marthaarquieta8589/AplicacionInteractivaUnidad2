using UnityEngine;
using TMPro;

public class ControlFuente : MonoBehaviour
{
    public TMP_Text titulo;

    public void AumentarFuente()
    {
        titulo.fontSize += 4;
    }

    public void DisminuirFuente()
    {
        if (titulo.fontSize > 20)
        {
            titulo.fontSize -= 4;
        }
    }
}

