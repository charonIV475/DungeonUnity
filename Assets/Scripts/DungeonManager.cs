using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DungeonManager : MonoBehaviour
{
    [SerializeField]

    private GameObject _mapParts = null;

    [SerializeField]
    private Transform _parent = null;

    [SerializeField]
    private List<Sprite> _mapChipSprites = new List<Sprite>();

    private int[,,] _mapData = new int[,,]
    {
        new List<List<int>>()
        {
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},













        }
    }



    // Start is called before the first frame update
    void Start()
    {
        MapMake();
    }

    private void MapMake()
    {
        foreach (int y in Enumerable.Range(0,20))
        {
            foreach (int x in Enumerable.Range(0,20))
            {
                GameObject gobj = Instantiate(_mapParts, _parent);
                gobj.transform.localPosition = new Vector3(x: x * 32, y: y * -32, z: 0);
            }
        }
    }
   
}
