using UnityEngine;
using UnityEngine.SceneManagement;

public class Navegacion : MonoBehaviour
{
    public void Inicio()
    {
        SceneManager.LoadScene("EscenaPrincipal");
    }

    public void Informacion()
    {
        SceneManager.LoadScene("EscenaInformacion");
    }

    public void Salir()
    {
        Application.Quit();
        Debug.Log("Saliendo de la aplicación");
    }
}

