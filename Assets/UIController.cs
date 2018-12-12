using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    //Objeto algo que iremos fazer as transfomações lineares
    public Transform TargetTransform;
   
    public float ZoomFactor = 0.1f;
    public float RotateFactor = 30;

    private float _zoomDefault;
   

    public void Awake()
    {
        _zoomDefault = TargetTransform.localScale.magnitude;
    }

    public void OnZoomIn()
    {
        //Faz o nosso target crescer
        TargetTransform.localScale += TargetTransform.localScale.normalized * ZoomFactor;
    }

    public void OnZoomOut()
    {
        //Faz o nosso target diminuir
        TargetTransform.localScale -= TargetTransform.localScale.normalized * ZoomFactor;
    }

    public void ResetZoom()
    {
        //Reseta o nosso alvo para o tamanho inicial
        TargetTransform.localScale = TargetTransform.localScale.normalized * _zoomDefault;
    }

    public void RotateRight()
    {
        //Rotaciona para direita
        TargetTransform.Rotate(Vector3.up, RotateFactor);
    }

    public void RotateLeft()
    {
        //Rotaciona para esquerda
        TargetTransform.Rotate(Vector3.up, -RotateFactor);

    }
}
