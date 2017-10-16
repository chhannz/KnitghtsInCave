using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAdventure : MonoBehaviour {
    public string myname;
    int switchNumber = 0;
    bool doorEntered;
	// Use this for initialization
	void Start () {
        doorEntered = false;
        print("The legendary treasure hunter, "+myname+" has arrived in the Dangerous Cave.");
        print("There is a door on the left. Open it using A button.");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A) && doorEntered == false)
        {
            doorEntered = true;
            print("You have entered a door.");
            print("There is a trap !! You are trapped !!");
            print("Solve the riddle to escape the trap !");
            print("The riddle is : How many doors that you encountered in the main entrance ?");
            print("You see a switch with number printed on it.");
            print("Press W to increase the number and S to decrease the number in the switch.");
        }

        if (Input.GetKeyDown(KeyCode.W) && doorEntered == true)
		{
			switchNumber++;
			print(switchNumber);
		}

        if (Input.GetKeyDown(KeyCode.S) && doorEntered == true)
		{
			switchNumber--;
			print(switchNumber);
		}
    }
	
}
