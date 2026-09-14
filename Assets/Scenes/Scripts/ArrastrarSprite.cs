using UnityEngine;
using UnityEngine.EventSystems;

public class ArrastrarSprite : MonoBehaviour, IDragHandler
{
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }
}
