using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarController : MonoBehaviour {

    public Text countText;
    public Text winText;
    private int count;
    AudioSource audioSource;
    AudioClip clip;

	// Use this for initialization
	void Start () {
        count = 0;
        winText.text = "";
        SetCountText();
        audioSource = GetComponent<AudioSource>();
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 15)
        {
            winText.text = "Congratulations, You win.";
        }
    }

    void OnCollisionEnter(Collision collision)
    {

        Debug.Log("Collided with " + collision.collider.name);

        if (collision.collider.gameObject.CompareTag("Phonics"))
        {
            collision.collider.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }


        switch (collision.collider.gameObject.name)
        {

            case "Cube A":
                clip = (AudioClip)Resources.Load("A");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "Cube B":
                clip = (AudioClip)Resources.Load("B");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "Cube C":
                clip = (AudioClip)Resources.Load("C");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "Cube D":
                clip = (AudioClip)Resources.Load("D");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "Cube E":
                clip = (AudioClip)Resources.Load("E");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "Cube F":
                clip = (AudioClip)Resources.Load("F");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "Cube G":
                clip = (AudioClip)Resources.Load("G");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "Cube H":
                clip = (AudioClip)Resources.Load("H");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "Cube I":
                clip = (AudioClip)Resources.Load("I");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "Cube J":
                clip = (AudioClip)Resources.Load("J");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "Cube K":
                clip = (AudioClip)Resources.Load("K");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "Cube L":
                clip = (AudioClip)Resources.Load("L");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "Cube M":
                clip = (AudioClip)Resources.Load("M");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "Cube N":
                clip = (AudioClip)Resources.Load("N");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "Cube O":
                clip = (AudioClip)Resources.Load("O");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "Cube P":
                clip = (AudioClip)Resources.Load("P");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "Cube Q":
                clip = (AudioClip)Resources.Load("Q");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "Cube R":
                clip = (AudioClip)Resources.Load("R");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "Cube S":
                clip = (AudioClip)Resources.Load("S");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "Cube T":
                clip = (AudioClip)Resources.Load("T");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "Cube U":
                clip = (AudioClip)Resources.Load("U");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "Cube V":
                clip = (AudioClip)Resources.Load("V");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "Cube W":
                clip = (AudioClip)Resources.Load("W");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "Cube X":
                clip = (AudioClip)Resources.Load("X");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "Cube Y":
                clip = (AudioClip)Resources.Load("Y");
                audioSource.clip = clip;
                audioSource.Play();
                break;
            case "Cube Z":
                clip = (AudioClip)Resources.Load("Z");
                audioSource.clip = clip;
                audioSource.Play();
                break;
        }

    }
}
