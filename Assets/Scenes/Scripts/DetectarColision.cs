using UnityEngine;

public class DetectarColision : MonoBehaviour
{
    private bool enElPiso = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "piso")
        {
            enElPiso = true;
            Debug.Log("El pingüino ha tocado el piso.");
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "piso")
        {
            enElPiso = false;
            Debug.Log("El pingüino dejó de tocar el piso.");
        }
    }
}
