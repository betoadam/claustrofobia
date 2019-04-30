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
	private bool cenaDC_flag = false;
	private bool cenaBaixaLuz_flag = false;
	public void LoadCena01(Transform wayPoint){
		Cena1Barra.gameObject.SetActive(true);
		Cena1Start.gameObject.SetActive(true);
			
	}
	public void DeLoadCena01(Transform wayPoint){
		cenaRV_flag = false;
		cenaCM_flag = false;
		cenaYT_flag = false;
		cenaDC_flag = false;
		cenaBaixaLuz_flag = false;
	}
	public void StartCena01(Transform wayPoint){
		cenaRV_flag = true;
		StartCoroutine(cenaRV());
	}
	public void StartCenaBaixaLuz(Transform wayPoint){
		cenaBaixaLuz_flag = true;
		StartCoroutine(cenaBaixaLuz());
	}
	public void StartCenaCM(Transform wayPoint){
		cenaCM_flag = true;
		StartCoroutine(cenaCM());
	}
	public void StartCenaYT(Transform wayPoint){
		cenaYT_flag = true;
		StartCoroutine(cenaYT());
	}
	public void StartCenaDC(Transform wayPoint){
		cenaDC_flag = true;
		StartCoroutine(cenaDC());
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
	IEnumerator cenaBaixaLuz(){
        yield return new WaitForSeconds(5.0f);
		if(cenaBaixaLuz_flag)
			SceneManager.LoadScene("SemLuz");	
    }
	IEnumerator cenaDC(){
        yield return new WaitForSeconds(5.0f);
		if(cenaDC_flag)
			SceneManager.LoadScene("Descida");	
    }
}
