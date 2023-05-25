using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Importe prieks interfeisiem
using UnityEngine.EventSystems;
public class DragDrop : MonoBehaviour, IPointerDownHandler,IBeginDragHandler,IDragHandler,IEndDragHandler {
    //uzglaba noradi uz objektu skriptiem
    public Objekti objektuSkripts;
    //Velkamam objektam piestiprinata CanvasGroup komponente
    private CanvasGroup kanvasGrupa;
    //Objekta atrašanas vieta kurš tiek parvietots
    private RectTransform velkObjRectTransf;


    void Start()
    {
        //Piekļūjst objektam piestiprinātajai CanvasGroup
        kanvasGrupa= GetComponent<CanvasGroup>();
        //Piekļūst objekta RectTransform componentei
        velkObjRectTransf= GetComponent<RectTransform>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Uzklikšķināts uz velkama objekta!");
        objektuSkripts.PedejaisVilktais = null;
        kanvasGrupa.alpha= 0.6f;
        kanvasGrupa.blocksRaycasts= false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        velkObjRectTransf.anchoredPosition += eventData.delta / objektuSkripts.kanva.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        objektuSkripts.PedejaisVilktais = eventData.pointerDrag;
        kanvasGrupa.alpha = 1f;

        if (objektuSkripts.vaiIstajaVieta == false)
        {
            kanvasGrupa.blocksRaycasts = true;
        }
        else
        {
            objektuSkripts.PedejaisVilktais = null;
        }

        objektuSkripts.vaiIstajaVieta= false;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
      

    }
}
