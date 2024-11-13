using System.Collections;
using System.Collections.Generic;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;
using UnityEngine;
using Unity.VisualScripting;

public class EventoMoneda : MonoBehaviour, MMEventListener<PickableItemEvent>
{
    public GameObject character;
    private Health vidaPersonaje;
    private CharacterJump jump;
    private int TeddyIcon = 0;

    private float tiempoInmunidad;



    public virtual void OnMMEvent(PickableItemEvent e)
    {  // Como hago para diferenciar que objeto estoy agarrando????

        Debug.Log("Objeto agarrado");
        TeddyIcon++;
        Debug.Log(TeddyIcon);


        if (TeddyIcon >= 2)
        {
            tiempoInmunidad = 5;
            activarInmunidad();
            //GameManager.Instance.AddPoints(1); // Aquí está implementado a mi manera
            //vidaPersonaje.Invulnerable = true; // Por qué esto si se cambia en el editor pero no se aplica al juego?????
            //vidaPersonaje.ImmuneToDamage = true;
            //jump.JumpHeight = 10;

            Debug.Log(vidaPersonaje);
        }
    }

    public Health getHealth()
    {
        character = LevelManager.Instance.Players[0].gameObject;
        return character.GetComponent<Health>();
    }

    public void activarInmunidad()
    {
        vidaPersonaje = getHealth();
        vidaPersonaje.Invulnerable = true;
        StartCoroutine(desactivarInmunidad());
    }

    public IEnumerator desactivarInmunidad()
    {
        yield return new WaitForSeconds(tiempoInmunidad);
        vidaPersonaje.Invulnerable = false;
        TeddyIcon = 0;
    }

    private void OnEnable()
    {
        this.MMEventStartListening<PickableItemEvent>();
    }

    private void OnDisable()
    {
        this.MMEventStopListening<PickableItemEvent>();
    }


    // Start is called before the first frame update
    void Start()
    {
        //GameManager.Instance.AddPoints(1); 
    }

    // Update is called once per frame
    void Update()
    {

    }
}
