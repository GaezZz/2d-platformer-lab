using UnityEngine;

public class CharacterStats : MonoBehaviour
{

    //script del game logic general
    public GameLogic gameLogic;

    public int life;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameLogic = GameObject.FindGameObjectWithTag("gameLogic").GetComponent<GameLogic>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    //quitarse la vida que le pase desde otro lado
    public void characterHit(int damage)
    {
        //cuando llega una invocacion de este metodo, cojo la vida actual y se la resto al daño que hace el enemigo/bala/etc
        life -= damage;
        Debug.Log(damage);

        //llamo a la funcion del game logic para mandarle la vida que queda una vez le hacen daño
        gameLogic.characterDead(life);
    }
}
