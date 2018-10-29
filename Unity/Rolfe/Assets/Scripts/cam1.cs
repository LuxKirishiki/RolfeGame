using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class cam1 : MonoBehaviour
{

	public Transform objetivo;
	public Vector3 distancia;
	public float velocidad_suavisado = 0.120f;
	public bool shakeCampoGravedad;
	public bool shakeEsferaBom;
	public Vector3 axisShakeMinCampoGravedad;
	public Vector3 axisShakeMaxCampoGravedad;
	public Vector3 axisShakeMinEsferaBom;
	public Vector3 axisShakeMaxEsferaBom;

	private void Start()
	{
   	
    	
	}
	void FixedUpdate()
	{
    	Vector3 posicion_deseada = objetivo.position + distancia;
    	Vector3 posicion_suavisada = Vector3.Lerp(transform.position, posicion_deseada, velocidad_suavisado * Time.deltaTime);
    	transform.position = posicion_suavisada;
    	if (shakeCampoGravedad==true)
    	{
       	transform.position = posicion_suavisada + new Vector3(Random.Range(axisShakeMinCampoGravedad.x, axisShakeMaxCampoGravedad.x),
       	Random.Range(axisShakeMinCampoGravedad.y, axisShakeMaxCampoGravedad.y), Random.Range(axisShakeMinCampoGravedad.z, axisShakeMaxCampoGravedad.z));
    	}
    	if (shakeEsferaBom==true)
    	{
      	transform.position = posicion_suavisada + new Vector3(Random.Range(axisShakeMinEsferaBom.x, axisShakeMaxEsferaBom.x),
      	Random.Range(axisShakeMinEsferaBom.y, axisShakeMaxEsferaBom.y), Random.Range(axisShakeMinEsferaBom.z, axisShakeMaxEsferaBom.z));
    	}
	}
 

}

