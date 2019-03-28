using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
	public GameObject Cena1Barra;
	public GameObject Cena1Start;
	private bool cenaRV_flag = false;
	private bool cenaCM_flag = false;
	private bool cenaYT_flag = false;
	public void LoadCena01(Transform wayPoint){
		Cena1Barra.gameObject.SetActive(true);
		Cena1Start.gameObject.SetActive(true);
			
	}
	public void DeLoadCena01(Transform wayPoint){
		cenaRV_flag = false;
		cenaCM_flag = false;
		cenaYT_flag = false;
	}
	public void StartCena01(Transform wayPoint){
		cenaRV_flag = true;
		StartCoroutine(cenaRV());
	}
	public void StartCenaCM(Transform wayPoint){
		cenaCM_flag = true;
		StartCoroutine(cenaCM());
	}
	public void StartCenaYT(Transform wayPoint){
		cenaYT_flag = true;
		StartCoroutine(cenaYT());
	}
	public void Menu(Transform wayPoint){
		SceneManager.LoadScene("Menu");	
	}
	IEnumerator cenaRV(){
        yield return new WaitForSeconds(5.0f);
		if(cenaRV_flag)
			SceneManager.LoadScene("RV");	
    }
	IEnumerator cenaCM(){
        yield return new WaitForSeconds(5.0f);
		if(cenaCM_flag)
			SceneManager.LoadScene("VideoCamera");	
    }
	IEnumerator cenaYT(){
        yield return new WaitForSeconds(5.0f);
		if(cenaYT_flag)
			SceneManager.LoadScene("VideoYT");	
    }
}
