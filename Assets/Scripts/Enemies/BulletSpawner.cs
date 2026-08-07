using UnityEngine;

public class BulletSpawner : MonoBehaviour
{

    //Al igual que tuve que decirle cual era el rigidbody, ahora le tengo que decir que prefab sacar
    public GameObject pipe;

    public float spwnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {

        if (timer < spwnRate) //miro cuanto tiempo esta "vivo" el prefab desde que sale, si al mirar lleva el anterior 1,5 seg, al no cumplir los 2 puestos no saca nada, asi hacemos ue cada 2s salga algo
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;

        }


    }

    //metodo nuevo para usarlo mas veces
    void spawnPipe()
    {
        //marco un punto maximo y minimo donde pueden salir
        float lowestPoint = transform.position.y - heightOffset;
        float highPoint = transform.position.y + heightOffset;

        //instantiate es un metodo para crear de forma random los prefabs por la pantalla, necesita el prefab, donde aparece y si tiene giro, lo pongo normal ya que  el movimiento lo hace el prefab solo
        //esto solo lo saca en la pantalla en un punto  
        //con Random.range le digo un minimo y un maximo de valores, cada iteracion coge un valoer de ese rango
        Instantiate(pipe, new Vector3(transform.position.x , Random.Range(lowestPoint,highPoint), transform.position.z), transform.rotation);
    }
}
