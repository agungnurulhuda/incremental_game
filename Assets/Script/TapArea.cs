/*using UnityEngine;

using UnityEngine.EventSystems;



public class TapArea : MonoBehaviour, IPointerDownHandler

{

    public void OnPointerDown(PointerEventData eventData)

    {

        GameManager.Instance.CollectByTap(eventData.position, transform);

    }

}*/
using UnityEngine;
using UnityEngine.EventSystems;

public class TapArea : MonoBehaviour, IPointerDownHandler
{
    AudioSource collectCoint;
    private void Start()
    {
        collectCoint = gameObject.GetComponent<AudioSource>();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        GameManager.Instance.CollectByTap(eventData.position, transform);
        collectCoint.Play();
    }
}