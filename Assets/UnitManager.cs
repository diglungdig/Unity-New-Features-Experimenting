using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public struct UnitPositionData
{
    public Vector3 position;
    public Quaternion rotation;
}

public class UnitManager : MonoBehaviour {

    static int currentCapacity = 0;
    static int firstEmptyIndex = 0;

    static bool[] isAlive;

    static Queue<int> deadUnits;

    static int[] hitpoints;
    static int[] armor;

    static UnitPositionData[] positionData;

    static public int CreateUnit()
    {
        if(currentCapacity <= firstEmptyIndex){
            if(deadUnits == null || deadUnits.Count == 0)
            {
                GrowUnitArray();
            }
            else
            {
                int deadSpot = deadUnits.Dequeue();

                isAlive[deadSpot] = true;

                return deadSpot;

            }
        }

        isAlive[firstEmptyIndex] = true;
        return firstEmptyIndex++;

    }

    static public void SetUnitHitpoints(int unitIndex, int h)
    {
        if (unitIndex < 0 || unitIndex >= currentCapacity)
            return;

        hitpoints[unitIndex] = h;
    }


    static public void KillUnit(int i)
    {
        isAlive[i] = false;

        deadUnits.Enqueue(i);
    }


    const int INITIAL_ARRAY_SIZE = 10;
    const int GROW_FACTOR = 2;


    static public void GrowUnitArray()
    {
        if(currentCapacity == 0)
        {
            currentCapacity = INITIAL_ARRAY_SIZE;
            isAlive = new bool[currentCapacity];
            hitpoints = new int[currentCapacity];
            armor = new int[currentCapacity];
            positionData = new UnitPositionData[currentCapacity];
            return;
        }

        currentCapacity = currentCapacity * GROW_FACTOR;

        Array.Resize(ref isAlive, currentCapacity);
        Array.Resize(ref hitpoints, currentCapacity);
        Array.Resize(ref armor, currentCapacity);
        Array.Resize(ref positionData, currentCapacity);
    }


    static public void AnUpdateExample()
    {
        for (int i = 0; i < currentCapacity - 1; i++)
        {
            if (isAlive[i] == false)
                continue;

            for (int j = i + 1; j < currentCapacity; j++)
            {
                if (isAlive[j] == false)
                    continue;

                bool isHigher = positionData[i].position.y > positionData[j].position.y;

            }
        }
    }

}
