using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Chase : MonoBehaviour
{
    //переменная, определяющая, включен ли режим слежения
    bool chase = false;
    //ссылки на камеру и планету, за которой нужно следить
    GameObject planet;
    public GameObject cam;
    //функция установки планеты для слежения
    public void Chase_Planet(GameObject p)
    {
        //режим слежения - включить
        chase = true;
        //назначить планету для слежения
        planet = p;
        //найти ссылку на камеру
       // cam = GameObject.Find("Camera");
    }
    //функция установки камеры в начальную позицию
    public void Camera_Reset(Transform sun)
    {
        //режим слежения - отключить
        chase = false;
        //найти ссылку на камеру
        //cam = GameObject.Find("Camera");
        //установить начальную позицию камеры
        cam.transform.position = new Vector3(0, 190, 0);
        //повернуть камеру в сторону солнца
        cam.transform.LookAt(sun);
    }

    //функция, вызываемая каждый кадр, после всех остальных изменения
    void LateUpdate()
    {
        //если включён режим слежения
        if (chase == true)
        {
            //установить камеру в позицию на орбите планеты
            cam.transform.position = planet.transform.position + new Vector3(15, 10, 0);
            //повернуть камеру в направлении центра планеты
            cam.transform.LookAt(planet.transform);
        }
    }
}