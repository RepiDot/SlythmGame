using UnityEngine;
using UnityEngine.EventSystems;

public class IPointerTest : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler, IBeginDragHandler, IDragHandler, IPointerDownHandler
{
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("StartDragHandler");
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("DragHandler");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("ClickHandler");
        //Destroy(this.gameObject);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("DownHandler");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("EnterHandler");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            //Debug.Log("GetMouseButtonDown");
        }
    }
}
