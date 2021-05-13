using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCounter : MonoBehaviour
{
    public int enemyCount;
    public void EnemyDownCounter ()
    {
       enemyCount++;
if(enemyCount==30){
SceneManager.LoadScene("invaders2");
}
    }

    // Update is called once per frame
   
}
