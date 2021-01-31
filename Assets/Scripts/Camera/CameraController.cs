using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Camera Cam;
    #region ManagerDoZoom
    //
    /// Variaveis responsaveis pelos valores que vão manipular o zoom da camera
    /// 
    [SerializeField] private float CameraDistanceMin, CameraDistanceMax, CameraDistance, ScrollSpeed;
    #endregion /ManagerDoZoom

    private void Update()
    {
        if (Game.GameIsPaused) return;

        ZoomManager();
    }
    void ZoomManager()
    {
        ///Vai utilizar a wheel do mouse pra manipular a distancia da camera usando uma velocidade determinada
        ///
        CameraDistance -= Input.GetAxis("Mouse ScrollWheel") * ScrollSpeed;
        CameraDistance = Mathf.Clamp(CameraDistance, CameraDistanceMin, CameraDistanceMax);

        Cam.orthographicSize = CameraDistance;
    }
}
