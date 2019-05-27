﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DataInteraction
{
    
    private static DataClass dataClass = new DataClass();

    public static int lastSaved = 0;

    private static DataClass.Hero _hero1;

    private static DataClass.Hero _hero2;

    private static DataClass.Hero _hero3;


    public static void FirstCharacterCreation()
    {
        _hero1 = new DataClass.Hero(1);
        _hero2 = new DataClass.Hero(2);
        _hero3 = new DataClass.Hero(3);
    }

    public static DataClass.Hero GetHero(int index)
    {
        switch (index)
        {
            case 1:
                return _hero1;
            case 2:
                return _hero2;
            case 3:
                return _hero3;
            default:
                return null;
        }
    }
}
