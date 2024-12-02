using UnityEngine;
using UnityEngine.EventSystems;

public class IPointerTest : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler, IBeginDragHandler, IDragHandler, IPointerDownHandler
{
    int i = -1;
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
        Destroy(this.gameObject);
        Debug.Log(GameObject.FindGameObjectsWithTag("Circle").Length);
        if(GameObject.FindGameObjectsWithTag("Circle").Length == 1) {
            Debug.Log("Quit");
            Application.Quit();
        }
        i = GameObject.FindGameObjectsWithTag("Circle").Length;
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
            Debug.Log("GetMouseButtonDown");
        }
    }
}
