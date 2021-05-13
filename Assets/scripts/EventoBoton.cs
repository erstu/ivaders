using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventoBoton : MonoBehaviour
{
    
    public void IniciarJuego()
    {
       SceneManager.LoadScene("invaders"); 
    }
}
