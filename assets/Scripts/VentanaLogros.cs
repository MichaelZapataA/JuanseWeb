using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VentanaLogro : MonoBehaviour
{
    [SerializeField]
    private string titulo;

    [SerializeField]
    private string descripci�n;

    [SerializeField]
    private bool desbloqueado;

    [SerializeField]
    private Image imagen; // La referencia de la imagen a mostrar o esconder

    public string Titulo { get => titulo; set => titulo = value; }
    public string Descripci�n { get => descripci�n; set => descripci�n = value; }

    // Controlar el estado de la variable desbloqueado
    public bool Desbloqueado
    {
        get => desbloqueado;
        set
        {
            desbloqueado = value;
            ActualizarVisibilidadImagen();
        }
    }

    // M�todo para actualizar la visibilidad de la imagen
    private void ActualizarVisibilidadImagen()
    {
        if (imagen != null)
        {
            imagen.gameObject.SetActive(desbloqueado); // Muestra u oculta la imagen seg�n el valor de desbloqueado
        }
    }

    // Llama a este m�todo para desbloquear el logro
    public void Desbloquear()
    {
        if (!desbloqueado)
        {
            Desbloqueado = true;
            Debug.Log("Logro desbloqueado: " + titulo);
        }
    }

    void Start()
    {
        // Asegurarse de que la imagen est� oculta si el logro no est� desbloqueado
        ActualizarVisibilidadImagen();
    }
}