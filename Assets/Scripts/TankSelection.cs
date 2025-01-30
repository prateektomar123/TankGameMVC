using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{
    public TankSpawner tankSpawner;

    public void BlueTankSelected()
    {
        tankSpawner.CreateTank(TankTypes.BlueTank);
    }

    public void GreenTankSelected()
    {
        tankSpawner.CreateTank(TankTypes.GreenTank);

    }

    public void RedTankSelected()
    {
        tankSpawner.CreateTank(TankTypes.RedTank);

    }
}
