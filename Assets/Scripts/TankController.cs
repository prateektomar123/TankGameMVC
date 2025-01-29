using UnityEngine;

public class TankController
{
    private TankView tankView;
    private TankModel tankModel;

    public TankController(TankModel _tankModel, TankView _tankView)
    {
        tankModel = _tankModel;
        tankView = _tankView;

        tankModel.SetTankController(this);
        tankView.SetTankController(this);
        GameObject.Instantiate(tankView.gameObject);
    }
}

