using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SplashScree : MonoBehaviour {

    public Image imageforSplash;
    private static bool keepFadeIn;
    private static bool keepFadeOut;
    public string LoadLevel;
    public AudioSource sirenAudio;

    // Use this for initialization
    IEnumerator Start() {
        imageforSplash.canvasRenderer.SetAlpha(0.0f);

        Gelsin();
        fadeSound();
        yield return new WaitForSeconds(2.5f);

        Getsin();
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(LoadLevel);
	}
	
	void Gelsin()
    {
        imageforSplash.CrossFadeAlpha(1.0f, 1.5f, false);

    }

    void Getsin()
    {
        imageforSplash.CrossFadeAlpha(0.0f, 2.5f, false);

    }
    IEnumerator fadeSound()
    {
        while(sirenAudio.volume > 0.01f)
        {
            sirenAudio.volume -= Time.deltaTime / 0.5f;
            yield return null;
        }
        sirenAudio.volume = 0;
        sirenAudio.Stop();
    }
    
}
