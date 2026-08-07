using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ProyectilMover : MonoBehaviour
{

    public float moveSpeed;

    public int bulletDamage; //le pongo un daño que luego le pasare a la vida para restarsela al pj

    //Buscar el script del personaje
    public CharacterStats character; //tengo que poner el nombre del script al que quiero entrar, las estadisticas del pj 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        character = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterStats>();
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += (Vector3.right * moveSpeed) * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision) //una vez sale si choca con algo se destruye
    { //para que interactuen con un isTrigger algunos de los 2 debe tenerun rigidbody obligado
        Debug.Log(collision.name);
        Destroy(gameObject);
        character.characterHit(bulletDamage); //llamo a la funcion de quitar la vida y le paso el daño que le hace
    }
}
