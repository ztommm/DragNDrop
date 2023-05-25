using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;

	public GameObject b2Masina;
	public GameObject CementaMasina;
	public GameObject e46Masina;
	public GameObject e61Masina;
	public GameObject Eskavators;
	public GameObject policijasMasina;
	public GameObject Traktors1;
	public GameObject Traktors5;
	public GameObject UgunsDzeseji;

	[HideInInspector]
	public Vector2 atkrMKoord;
	[HideInInspector]
	public Vector2 atrPKoord;
	[HideInInspector]
	public Vector2 bussKoord;

    [HideInInspector]
    public Vector2 b2Koord;
    [HideInInspector]
    public Vector2 cementaKoord;
    [HideInInspector]
    public Vector2 e46Koord;
    [HideInInspector]
    public Vector2 e61Koord;
    [HideInInspector]
    public Vector2 eskavatoraKoord;
	[HideInInspector]
	public Vector2 policijasKoord;
    [HideInInspector]
    public Vector2 traktora1Koord;
    [HideInInspector]
    public Vector2 traktora6Koord;
    [HideInInspector]
    public Vector2 ugunsdzKoord;

    public Canvas kanva;
	public AudioSource skanasAvots;
	public AudioClip[] skanasKoAtskanot;

	[HideInInspector]
	public bool vaiIstajaVieta = false;

	public GameObject pedejaisVilktais = null;


	void Start() {
		atkrMKoord =
        atkritumuMasina.GetComponent<RectTransform>().localPosition;
        
		atrPKoord =
        atraPalidziba.GetComponent<RectTransform>().localPosition;

        bussKoord =
		autobuss.GetComponent<RectTransform>().localPosition;

        b2Koord =
        b2Masina.GetComponent<RectTransform>().localPosition;

        cementaKoord =
        CementaMasina.GetComponent<RectTransform>().localPosition;

        e46Koord =
                e46Masina.GetComponent<RectTransform>().localPosition;
       
        e61Koord =
        e61Masina.GetComponent<RectTransform>().localPosition;

        eskavatoraKoord =
        Eskavators.GetComponent<RectTransform>().localPosition;

        policijasKoord =
        policijasMasina.GetComponent<RectTransform>().localPosition;

        traktora1Koord =
        Traktors1.GetComponent<RectTransform>().localPosition;

        traktora6Koord =
        Traktors5.GetComponent<RectTransform>().localPosition;

        ugunsdzKoord =
        UgunsDzeseji.GetComponent<RectTransform>().localPosition;

    }
}
