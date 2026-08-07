using UnityEngine;

public class CharacterStats : MonoBehaviour
{

    public int life;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

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
    }
}
