using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Keycards
{
    //static bools for whether the player has the keycard or not
    private static bool yellowKeyCard = false;
    private static bool redKeyCard = false;
    private static bool blueKeyCard = false;
    private static bool greenKeyCard = false;


    //checks to see if the player has the yellow key card
    public static bool gotYellowCard
    {
        get
        {
            return yellowKeyCard;
        }
        set
        {
            yellowKeyCard = value;
        }
    }

    //checks to see if the player has the red key card
    public static bool gotRedCard
    {
        get
        {
            return redKeyCard;
        }
        set
        {
            redKeyCard = value;
        }
    }

    //checks to see if the player has the blue key card.
    public static bool gotBlueCard
    {
        get
        {
            return blueKeyCard;
        }
        set
        {
            blueKeyCard = value;
        }
    }

    //checks to see if the player has the green keycard
    public static bool gotGreenCard
    {
        get
        {
            return greenKeyCard;
        }
        set
        {
            greenKeyCard = value;
        }
    }


}
