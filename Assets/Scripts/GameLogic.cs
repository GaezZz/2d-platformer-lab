using UnityEngine;

public class GameLogic : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void characterDead(int vidaCharacter) //le voy a enviar desde el script del player la vida restante
    {
        if (vidaCharacter <= 0) //compruebo si la vida restante baja de 0 y lo mato (reinicio la escena, hago X)
        {
            Debug.Log("MUERTOS");
        }
    }
}
