using UnityEngine;

public class GoldNugget : MonoBehaviour, IPickupable
{
    Map map;
    GameManager gm;

    private void Start()
    {
        gm = GameManager.Instance;
        map = Map.Instance;
    }

    public void Pickup()
    {
        map.RemoveObstacle(transform);
        gm.AddGold();
        Destroy(gameObject);
    }
}