using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventoBotonMenu : MonoBehaviour
{
    
    public void IniciarJuego()
    {
       SceneManager.LoadScene("menu"); 
    }
}
