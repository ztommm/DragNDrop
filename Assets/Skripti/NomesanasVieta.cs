using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NomesanasVieta : MonoBehaviour, 
	IDropHandler{
	private float vietasZRot, velkObjZRot, rotacijasStarpiba;
	private Vector2 vietasIzm, velkObjIzm;
	private float xIzmStarpiba, yIzmStarpiba;
	public Objekti objektuSkripts;
    

    void Start()
    {
       objektuSkripts.UzvarasEkrans.SetActive(false);
       objektuSkripts.Zvaigzne1.SetActive(false);
       objektuSkripts.Zvaigzne2.SetActive(false);
       objektuSkripts.Zvaigzne3.SetActive(false);

    }

    public void OnDrop(PointerEventData eventData)
    {
        
        if (eventData.pointerDrag != null)
		{
			if (eventData.pointerDrag.tag.Equals(tag))
			{
				vietasZRot =
				eventData.pointerDrag.
				GetComponent<RectTransform>().transform.eulerAngles.z;

				velkObjZRot =
				GetComponent<RectTransform>().transform.eulerAngles.z;

				rotacijasStarpiba =
				Mathf.Abs(vietasZRot - velkObjZRot);

				vietasIzm =
				eventData.pointerDrag.
				GetComponent<RectTransform>().localScale;

				velkObjIzm =
					GetComponent<RectTransform>().localScale;

				xIzmStarpiba = Mathf.Abs(vietasIzm.x - velkObjIzm.x);
				yIzmStarpiba = Mathf.Abs(vietasIzm.y - velkObjIzm.y);

				Debug.Log("Objektu rotācijas starpība: " + rotacijasStarpiba
					+ "\nPlatuma starpība: " + xIzmStarpiba +
					"\nAugstuma starpība: " + yIzmStarpiba);


				if ((rotacijasStarpiba <= 6 ||
					(rotacijasStarpiba >= 354 && rotacijasStarpiba <= 360))
					&& (xIzmStarpiba <= 0.1 && yIzmStarpiba <= 0.1))
				{
					Debug.Log("Nomests pareizajā vietā!");
                    objektuSkripts.vaiIstajaVieta = true;
                    
                    
                    eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition
						= GetComponent<RectTransform>().anchoredPosition;

					eventData.pointerDrag.GetComponent<RectTransform>().localRotation =
						GetComponent<RectTransform>().localRotation;

					eventData.pointerDrag.GetComponent<RectTransform>().localScale =
						GetComponent<RectTransform>().localScale;

                    
              

                    switch (eventData.pointerDrag.tag) {
						case "atkritumi":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[1]);
                            objektuSkripts.PareizasMasinas++;
							break;

						case "atrie":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[2]);
                            objektuSkripts.PareizasMasinas++;
                            
                            break;

						case "buss":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[3]);
                            objektuSkripts.PareizasMasinas++;
                            
                            break;

                        case "b2":
                            objektuSkripts.skanasAvots.PlayOneShot(
                                objektuSkripts.skanasKoAtskanot[6]);
                            objektuSkripts.PareizasMasinas++;
                          
                            break;
                        case "cements":
                            objektuSkripts.skanasAvots.PlayOneShot(
                                objektuSkripts.skanasKoAtskanot[12]);
                            objektuSkripts.PareizasMasinas++;

                            break;
                        case "e46":
                            objektuSkripts.skanasAvots.PlayOneShot(
                                objektuSkripts.skanasKoAtskanot[7]);
                            objektuSkripts.PareizasMasinas++;
                            break;
                        case "e61":
                            objektuSkripts.skanasAvots.PlayOneShot(
                                objektuSkripts.skanasKoAtskanot[6]);
                            objektuSkripts.PareizasMasinas++;
                            break;
                        case "eskavators":
                            objektuSkripts.skanasAvots.PlayOneShot(
                                objektuSkripts.skanasKoAtskanot[11]);
                            objektuSkripts.PareizasMasinas++;
                            break;
                        case "policija":
                            objektuSkripts.skanasAvots.PlayOneShot(
                                objektuSkripts.skanasKoAtskanot[8]);
                            objektuSkripts.PareizasMasinas++;
                            break;
                            
                        case "traktors1":
                            objektuSkripts.skanasAvots.PlayOneShot(
                                objektuSkripts.skanasKoAtskanot[10]);
                            objektuSkripts.PareizasMasinas++;
                            break;
                        case "traktors5":
                            objektuSkripts.skanasAvots.PlayOneShot(
                                objektuSkripts.skanasKoAtskanot[11]);
                            objektuSkripts.PareizasMasinas++;
                            break;
                        case "ugunsdzeseji":
                            objektuSkripts.skanasAvots.PlayOneShot(
                                objektuSkripts.skanasKoAtskanot[13]);
                            objektuSkripts.PareizasMasinas++;
                            break;
                            
                        default:
							Debug.Log("Tags nav definēts!");
							break;
					}
                    

                    if (objektuSkripts.PareizasMasinas == 1)
                    {
                        Time.timeScale = 0;
                        objektuSkripts.UzvarasEkrans.SetActive(true);
                    }
                }
                

                //Ja tagi nesakrīt, tātad nepareizajā vietā
            } else	{
				objektuSkripts.vaiIstajaVieta = false;
				objektuSkripts.skanasAvots.PlayOneShot(
					objektuSkripts.skanasKoAtskanot[0]);

                switch (eventData.pointerDrag.tag){
                    case "atkritumi":
						objektuSkripts.atkritumuMasina.
						GetComponent<RectTransform>().localPosition =
						objektuSkripts.atkrMKoord;
                        break;

                    case "atrie":
                        objektuSkripts.atraPalidziba.
                        GetComponent<RectTransform>().localPosition =
                        objektuSkripts.atrPKoord;
                        break;

                    case "buss":
                        objektuSkripts.autobuss.
                         GetComponent<RectTransform>().localPosition =
                         objektuSkripts.bussKoord;
                        break;
                 

                    case "b2":
                        objektuSkripts.b2Masina.
                         GetComponent<RectTransform>().localPosition =
                         objektuSkripts.b2Koord;
                        break;
                    case "cements":
                        objektuSkripts.CementaMasina.
                         GetComponent<RectTransform>().localPosition =
                         objektuSkripts.cementaKoord;
                        break;
                    case "e46":
                        objektuSkripts.e46Masina.
                         GetComponent<RectTransform>().localPosition =
                         objektuSkripts.e46Koord;
                        break;
                    case "e61":
                        objektuSkripts.e61Masina.
                         GetComponent<RectTransform>().localPosition =
                         objektuSkripts.e61Koord;
                        break;
                    case "eskavators":
                        objektuSkripts.Eskavators.
                         GetComponent<RectTransform>().localPosition =
                         objektuSkripts.eskavatoraKoord;
                        break;
                    case "policija":
                        objektuSkripts.policijasMasina.
                         GetComponent<RectTransform>().localPosition =
                         objektuSkripts.policijasKoord;
                        break;
                    case "traktors1":
                        objektuSkripts.Traktors1.
                         GetComponent<RectTransform>().localPosition =
                         objektuSkripts.traktora1Koord;
                        break;
                    case "traktors5":
                        objektuSkripts.Traktors5.
                         GetComponent<RectTransform>().localPosition =
                         objektuSkripts.traktora6Koord;
                        break;
                    case "ugunsdzeseji":
                        objektuSkripts.UgunsDzeseji.
                         GetComponent<RectTransform>().localPosition =
                         objektuSkripts.ugunsdzKoord;
                        break;
                 
                    default: 
                        Debug.Log("Tags nav definēts!");
                        break;
                }
            }
		}
		
	}
}
