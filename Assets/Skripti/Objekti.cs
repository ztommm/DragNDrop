using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	public GameObject AtkritumuMasina;
    public GameObject AtraPalidziba;
    public GameObject Autobuss;

	[HideInInspector]
	public Vector2 atkrMKoord;
	[HideInInspector]
	public Vector2 atrPKoord;
	[HideInInspector]
	public Vector2 bussKoord;

	public Canvas kanva;
	public AudioSource skanasAvots;
	public AudioClip[] skanasKoAtskanot;

	[HideInInspector]
	public bool vaiIstajaVieta = false;

	public GameObject PedejaisVilktais = null;

    void Start () {
		atkrMKoord= AtkritumuMasina.GetComponent<RectTransform>().localPosition;
        atrPKoord = AtraPalidziba.GetComponent<RectTransform>().localPosition;
        bussKoord = Autobuss.GetComponent<RectTransform>().localPosition;
    }
	
}
