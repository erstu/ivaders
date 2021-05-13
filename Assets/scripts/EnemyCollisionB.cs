using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCollisionB : MonoBehaviour
{
public GameObject gameBrain,explosion,soundManager;


    void OnTriggerEnter(Collider colObj)
    {
     if(colObj.gameObject.tag=="Bullet")
{
     


soundManager.SendMessage("PlayExplosionSound");
gameBrain.SendMessage("EnemyDownCounter");
GameObject newExplosion=Instantiate(explosion,transform.position,Quaternion.identity);
Destroy(newExplosion,2);
Destroy(gameObject);
Destroy(colObj.gameObject);
ScoreScript.scoreValue += 2;
}   
if(colObj.gameObject.name=="Player")
{
Destroy(colObj.gameObject);
SceneManager.LoadScene("GameOver");
}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}