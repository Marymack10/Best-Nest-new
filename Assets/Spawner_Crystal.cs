using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Crystal : MonoBehaviour
{

    public GameObject purpleCrystal;

    public void SpawnCrystal()
    {
        Instantiate(purpleCrystal);
    }

}
