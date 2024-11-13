using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VentanaLogro : MonoBehaviour
{
    [SerializeField]
    private string titulo;

    [SerializeField]
    private string descripción;

    [SerializeField]
    private bool desbloqueado;

    [SerializeField]
    private Image imagen; // La referencia de la imagen a mostrar o esconder

    public string Titulo { get => titulo; set => titulo = value; }
    public string Descripción { get => descripción; set => descripción = value; }

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

    // Método para actualizar la visibilidad de la imagen
    private void ActualizarVisibilidadImagen()
    {
        if (imagen != null)
        {
            imagen.gameObject.SetActive(desbloqueado); // Muestra u oculta la imagen según el valor de desbloqueado
        }
    }

    // Llama a este método para desbloquear el logro
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
        // Asegurarse de que la imagen está oculta si el logro no está desbloqueado
        ActualizarVisibilidadImagen();
    }
}