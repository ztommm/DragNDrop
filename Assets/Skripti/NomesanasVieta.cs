﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NomesanasVieta : MonoBehaviour,IDropHandler {

		private float vietasZrot, velkObjZRot, rotacijasStarpiba;
	private Vector2 vietasIzm, velkObjIzm;
	private float xIzmStarpiba, yIzmStarpiba;
	public Objekti objektuSkripts;
    public void OnDrop(PointerEventData eventData)
    {
       if(eventData.pointerDrag!=null)
		{
			if(eventData.pointerDrag.tag.Equals(tag))
			{
				vietasZrot = eventData.pointerDrag.GetComponent<RectTransform>().transform.eulerAngles.z;

				velkObjZRot=GetComponent<RectTransform>().transform.eulerAngles.z;

				rotacijasStarpiba=Mathf.Abs(vietasZrot-velkObjZRot);

				vietasIzm = eventData.pointerDrag.GetComponent<RectTransform>().localScale;

				velkObjIzm=GetComponent<RectTransform>().localScale;

				xIzmStarpiba = Mathf.Abs(vietasIzm.x - velkObjIzm.x);
                yIzmStarpiba = Mathf.Abs(vietasIzm.y - velkObjIzm.y);

                Debug.Log("Objektu rotācijas starpība: "+rotacijasStarpiba+"\nPlatuma starpība: "+xIzmStarpiba + "\nAugstuma starpība: " + yIzmStarpiba);


				if ((rotacijasStarpiba <= 6 || (rotacijasStarpiba >= 354 && rotacijasStarpiba <= 360)) && (xIzmStarpiba <= 0.1 && yIzmStarpiba <= 0.1))
				{

					Debug.Log("Nomests pareizajā vietā!");
					objektuSkripts.vaiIstajaVieta = true;
					eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition=GetComponent<RectTransform>().position;
					eventData.pointerDrag.GetComponent<RectTransform>().localRotation = GetComponent<RectTransform>().localRotation;
					eventData.pointerDrag.GetComponent<RectTransform>().localScale = GetComponent<RectTransform>().localScale;

					switch (eventData.pointerDrag.tag)
					{
						case "Atkritumi":
							objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[1]);
								break;
                        case "Atrie":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[2]);
                            break;
                        case "Buss":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[3]);
                            break;
						default:
							Debug.Log("Tags nav definēts!");
							break;

                    }
                }
			}
			//Ja tagi nesakrti tatad nepareiza vieta
			else
			{
				objektuSkripts.vaiIstajaVieta = false;
				objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[0]);

                switch (eventData.pointerDrag.tag)
                {
                    case "Atkritumi":
						objektuSkripts.AtkritumuMasina.GetComponent<RectTransform>().localPosition = objektuSkripts.atkrMKoord;
                        break;
                    case "Atrie":
                        objektuSkripts.AtraPalidziba.GetComponent<RectTransform>().localPosition = objektuSkripts.atrPKoord;
                        break;
                    case "Buss":
                        objektuSkripts.Autobuss.GetComponent<RectTransform>().localPosition = objektuSkripts.bussKoord;
                        break;
                    default:
                        Debug.Log("Tags nav definēts!");
                        break;

                }
            }
		}
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
