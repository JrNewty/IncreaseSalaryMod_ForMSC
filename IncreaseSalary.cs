using MSCLoader;
using UnityEngine;
using HutongGames.PlayMaker;

namespace IncreaseSalary
{
    public class IncreaseSalary : Mod
    {
        public override string ID => "IncreaseSalary"; // Your (unique) mod ID 
        public override string Name => "IncreaseSalary"; // Your mod name
        public override string Author => "TheMakarchikYT"; // Name of the Author (your name)
        public override string Version => "1.0"; // Version
        public override string Description => "This mod increases your salary on Futufon job :)"; // Short description of your mod 
        public override Game SupportedGames => Game.MyWinterCar;

        public override void ModSetup()
        {
            SetupFunction(Setup.PostLoad, Mod_PostLoad);
        }

        private void Mod_PostLoad()
        {
            GameObject factoryObj = GameObject.Find("JOBS/FACTORY");

            if (factoryObj != null)
            {
                PlayMakerFSM fsm = ActionHelpers.GetGameObjectFsm(factoryObj, "PlayerData");

                if (fsm != null)
                {
                    fsm.FsmVariables.GetFsmFloat("Salary").Value = 7310f;
                    fsm.FsmVariables.GetFsmFloat("Salary2").Value = 10520;

                }
            }

            GameObject sheetObj1 = GameObject.Find("Sheets/JobContract/TextsCommon/5");

            if (sheetObj1 != null)
            {
                TextMesh tm1 = sheetObj1.GetComponent<TextMesh>();
                if (tm1 != null)
                {
                    tm1.text = "7310";
                }
            }

            GameObject sheetObj2 = GameObject.Find("Sheets/JobContract/TextsCommon/6");

            if (sheetObj2 != null)
            {
                TextMesh tm2 = sheetObj2.GetComponent<TextMesh>();
                if (tm2 != null)
                {
                    tm2.text = "10520";
                }
            }
        }
    }
}
