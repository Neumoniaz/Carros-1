
using UnityEngine;

[CreateAssetMenu(fileName = "NewCar", menuName = "Car/NewCar")]

public class CarSo : ScriptableObject
{
    public float speed;
    public float brakeForce;
    public float angle;
}
