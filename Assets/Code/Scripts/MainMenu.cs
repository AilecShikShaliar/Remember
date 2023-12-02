using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Librer�a para poder cambiar entre escenas

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            
           transform.position = new Vector2(-1.51f, -2.54f);
        }
        //Si estamos pulsando abajo
        else if(Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
           
            transform.position = new Vector2(-2.72f, -3.98f);
        }

        if(transform.position.y == -1.51 && Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            //Cargamos la escena con ese nombre
            SceneManager.LoadScene("Game");
        }
    }
}
