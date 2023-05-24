using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;


	//Uzglabās katra transportlīdzekļa sākotnējo atrašanās vietu
	[HideInInspector]
	public Vector2 atkrMKoord;
	[HideInInspector]
	public Vector2 atrPKoord;
	[HideInInspector]
	public Vector2 bussKoord;

	public Canvas kanva;

	//Uzglabās audio avotu, kurā atskaņot audio efektus
	public AudioSource skanasAvots;
	//Uzglabās audio failus
	public AudioClip[] skanaKoAtskanot;

	[HideInInspector]
	public bool vaiIstajaVieta = false;
	public GameObject pedejaisVilktais = null;
	// Use this for initialization
	void Start () {
		//Uzsakot spēli piefiksē kur sākotnēji atrodas katra mašīna
		atkrMKoord = atkritumuMasina.GetComponent<RectTransform>().localPosition;
        atrPKoord = atraPalidziba.GetComponent<RectTransform>().localPosition;
        bussKoord = autobuss.GetComponent<RectTransform>().localPosition;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
