using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EventUI : MonoBehaviour
{
    public List<GameObject> listaInstrucciones;
    public int currentIndex = 0;
    public List<string> cadenasInstrucciones;
    public TextMeshProUGUI textMeshProUGUI;
    private void Awake() 
    {
        DontDestroyOnLoad(this.gameObject);    
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateVisibility();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdateVisibility() 
    {
        for (int i = 0; i < listaInstrucciones.Count; i++) 
        {
            listaInstrucciones[i].SetActive(i == currentIndex);
        }
    }

    public void ChangeSceneByIndex(int sceneIndex)
    {
    SceneManager.LoadScene(sceneIndex);
    }

    public void ChangeSceneByName(string sceneName) 
    {
        SceneManager.LoadScene(sceneName);
    }

    public void CycleObject() 
    {
        currentIndex = (currentIndex + 1) % listaInstrucciones.Count;

        UpdateVisibility();
    }

    private void UpdateText() 
    {
        if ()
    } 
    public void ExitGame()
    {
        Debug.Log("Va a salir");
        Application.Quit();
        Debug.Log("Ya salió");
    }
}
