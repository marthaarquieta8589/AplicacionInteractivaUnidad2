using UnityEngine;

public class Navegacion : MonoBehaviour
{
    public void Inicio()
    {
        Debug.Log("Navegando a Inicio");
    }

    public void Informacion()
    {
        Debug.Log("Navegando a Información");
    }

    public void Salir()
    {
        Debug.Log("Saliendo de la aplicación");
        Application.Quit();
    }
}
