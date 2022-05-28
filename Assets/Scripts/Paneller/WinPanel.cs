using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinPanel : MonoBehaviour
{
    [SerializeField] Text _sonText;


    public void SifirlaOnClick()
    {

        PlayerPrefs.SetInt("Seviye", 0);
        SceneManager.LoadScene(0);

    }

    public void AnaMenuOnClick()
    {
        // StartCoroutine(AnaMenuDon());
        SceneManager.LoadScene(0);

    }

    //IEnumerator OyunSifirla()
    //{
    //    PlayerPrefs.SetInt("Seviye", 0);
    //    yield return new WaitForSeconds(0.5f);
    //    _sonText.text = "Oyun Sýfýrlandý";
    //    yield return new WaitForSeconds(1);
    //    _sonText.text = "Ana menüye yönlendiriliyorsunuz";
    //    yield return new WaitForSeconds(1.3f);
    //    SceneManager.LoadScene(0);
    //}

    //IEnumerator AnaMenuDon()
    //{
    //    _sonText.text = "Ana menüye yönlendiriliyorsunuz";
    //    yield return new WaitForSeconds(1.3f);
    //    SceneManager.LoadScene(0);
    //}
}
