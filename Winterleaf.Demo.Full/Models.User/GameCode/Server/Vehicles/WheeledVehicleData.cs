﻿// WinterLeaf Entertainment
// Copyright (c) 2014, WinterLeaf Entertainment LLC
// 
// All rights reserved.
// 
// The use of the WinterLeaf Entertainment LLC OMNI "Community Edition" is governed by this license agreement ("Agreement").
// 
// These license terms are an agreement between WinterLeaf Entertainment LLC and you.  Please read them. They apply to the source code and any other assets or works that are included with the product named above, which includes the media on which you received it, if any. These terms also apply to any updates, supplements, internet-based services, and support services for this software and its associated assets, unless other terms accompany those items. If so, those terms apply. You must read and agree to this Agreement terms BEFORE installing OMNI "Community Edition" to your hard drive or using OMNI in any way. If you do not agree to the license terms, do not download, install or use OMNI. Please make copies of this Agreement for all those in your organization who need to be familiar with the license terms.
// 
// This license allows companies of any size, government entities or individuals to create, sell, rent, lease, or otherwise profit commercially from, games using executables created from the source code that accompanies OMNI "Community Edition".
// 
// BY CLICKING THE ACCEPTANCE BUTTON AND/OR INSTALLING OR USING OMNI "Community Edition", THE INDIVIDUAL ACCESSING OMNI ("LICENSEE") IS CONSENTING TO BE BOUND BY AND BECOME A PARTY TO THIS AGREEMENT. IF YOU DO NOT ACCEPT THESE TERMS, DO NOT INSTALL OR USE OMNI. IF YOU COMPLY WITH THESE LICENSE TERMS, YOU HAVE THE RIGHTS BELOW:
// 
// Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
// 
//     Redistributions of source code must retain the all copyright notice, this list of conditions and the following disclaimer.
//     Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
//     With respect to any Product that the Licensee develop using the Software:
//     Licensee shall:
//         display the OMNI Logo, in the start-up sequence of the Product (unless waived by WinterLeaf Entertainment);
//         display in the "About" box or in the credits screen of the Product the text "OMNI by WinterLeaf Entertainment";
//         display the OMNI Logo, on all external Product packaging materials and the back cover of any printed instruction manual or the end of any electronic instruction manual;
//         notify WinterLeaf Entertainment in writing that You are publicly releasing a Product that was developed using the Software within the first 30 days following the release; and
//         the Licensee hereby grant WinterLeaf Entertainment permission to refer to the Licensee or the name of any Product the Licensee develops using the Software for marketing purposes. All goodwill in each party's trademarks and logos will inure to the sole benefit of that party.
//     Neither the name of WinterLeaf Entertainment LLC or OMNI nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
//     The following restrictions apply to the use of OMNI "Community Edition":
//     Licensee may not:
//         create any derivative works of OMNI Engine, including but not limited to translations, localizations, or game making software other than Games;
//         redistribute, encumber, sell, rent, lease, sublicense, or otherwise transfer rights to OMNI "Community Edition"; or
//         remove or alter any trademark, logo, copyright or other proprietary notices, legends, symbols or labels in OMNI Engine; or
//         use the Software to develop or distribute any software that competes with the Software without WinterLeaf Entertainment’s prior written consent; or
//         use the Software for any illegal purpose.
// 
// THIS SOFTWARE IS PROVIDED BY WINTERLEAF ENTERTAINMENT LLC ''AS IS'' AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL WINTERLEAF ENTERTAINMENT LLC BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE. 

#region

using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Containers;

#endregion

namespace LaughingDogStudios.Salvage.Logic.Models.User.Extendable
{
    public partial class WheeledVehicleData
    {
        public override bool OnFunctionNotFoundCallTorqueScript()
        {
            return false;
        }

        public override void onAdd(GameBase obj)
        {
            WheeledVehicle wheeledvehicle = obj._ID;
            base.onAdd(obj);
            //int nsd = (nameSpaceDepth + 1);
            //console.ParentExecute(thisobj, "onAdd", nsd, new string[] { thisobj, obj });
            // Setup the car with some tires & springs
            for (int i = wheeledvehicle.getWheelCount() - 1; i >= 0; i--)
                {
                wheeledvehicle.setWheelTire(i, "CheetahCarTire");
                wheeledvehicle.setWheelSpring(i, "CheetahCarSpring");
                wheeledvehicle.setWheelPowered(i, false);
                }
            // Steer with the front tires
            wheeledvehicle.setWheelSteering(0, 1);
            wheeledvehicle.setWheelSteering(1, 1);

            // Only power the two rear wheels... assuming there are only 4 wheels.
            wheeledvehicle.setWheelPowered(2, true);
            wheeledvehicle.setWheelPowered(3, true);
        }

        public override void onCollision(ShapeBase obj, SceneObject collObj, Point3F vec, float len)
        {
            // Collision with other objects, including items
        }

        // Used to kick the players out of the car that your crosshair is over

        [ConsoleInteraction(true)]
        public static void serverCmdcarUnmountObj(GameConnection client, Player obj)
        {
            obj.unmount();
            obj.setControlObject(obj);

            TransformF ejectpos = obj.getTransform();
            ejectpos += new TransformF(0, 0, 5);
            obj.setTransform(ejectpos);

            Vehicle mvehicle = obj["mVehicle"];

            Point3F ejectvel = mvehicle.getVelocity();
            ejectvel += new Point3F(0, 0, 10);

            ejectvel = ejectvel.vectorScale(((SimDataBlock) (obj.getDataBlock()))["mass"].AsFloat());

            obj.applyImpulse(ejectpos.GetPosition(), ejectvel);
        }

        // Used to flip the car over if it manages to get stuck upside down

        [ConsoleInteraction(true)]
        public static void serverCmdflipCar(GameConnection client)
        {
            Player player = client["player"];

            Vehicle car = player.getControlObject();
            if (car.getClassName() != "WheeledVehicle")
                return;
            TransformF carpos = car.getTransform();
            carpos += new TransformF(0, 0, 3);
            car.setTransform(carpos);
        }

        [ConsoleInteraction(true)]
        public static void serverCmdsetPlayerControl(GameConnection client)
        {
            Player player = client["player"];
            client.setControlObject(player);
        }

        [ConsoleInteraction(true)]
        public static void serverCmddismountVehicle(GameConnection client)
        {
            Player player = client["player"];
            Vehicle car = player.getControlObject();
            Player passenger = car.getMountNodeObject(0);

            ((PlayerData) passenger.getDataBlock()).doDismount(passenger);
            client.setControlObject(player);
        }
    }
}