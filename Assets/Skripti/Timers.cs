using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timers : MonoBehaviour {
	public Text textSeconds;
	private float time;
	
	public enum TimerFormats
	{
		Pilns,
		DesmitDalas,
		SimtDalas
	}


    [Header("Format Settings")]
    public bool hasFormat;
    public TimerFormats format;
    private Dictionary<TimerFormats, string> timeFormats = new Dictionary<TimerFormats, string>();
    // Use this for initialization
	 void Start () {
		timeFormats.Add(TimerFormats.Pilns, "0");
		timeFormats.Add(TimerFormats.DesmitDalas, "0.0");
		timeFormats.Add(TimerFormats.SimtDalas, "0.00");
	}

	

	// Update is called once per frame
	void Update () {
		time += Time.deltaTime; //
		textSeconds.text = time.ToString();
		SetTimerText();
	}

	private void SetTimerText()
	{
		textSeconds.text = hasFormat ? time.ToString(timeFormats[format]) : time.ToString();
	}
}
