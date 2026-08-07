using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ProyectilMover : MonoBehaviour
{

    public float moveSpeed;

    //Buscar el script de la zona del spawn
    //public ProyectilSpawn spawn; //tengo que poner el nombre del script al que quiero entrar

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //spawn = GameObject.FindGameObjectWithTag("bulletSpawn").GetComponent<ProyectilSpawn>();
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += (Vector3.right * moveSpeed) * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision) //una vez sale si choca con algo se destruye y le digo al otro script que ya no existe con el isDead
    { //para que interactuen con un isTrigger algunos de los 2 debe tenerun rigidbody obligado
        Debug.Log(collision.name);
        Destroy(gameObject); 
        //spawn.isDead = true;
    }
}
