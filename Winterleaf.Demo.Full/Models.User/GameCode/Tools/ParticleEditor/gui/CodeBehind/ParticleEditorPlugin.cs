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

using System.ComponentModel;
using LaughingDogStudios.Salvage.Logic.Models.User.Extendable;
using LaughingDogStudios.Salvage.Logic.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.PlugIns;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace LaughingDogStudios.Salvage.Logic.Models.User.GameCode.Tools.ParticleEditor.gui.CodeBehind
{
    [TypeConverter(typeof (TypeConverterGeneric<ParticleEditorPlugin>))]
    public class ParticleEditorPlugin : WorldEditorPlugin
    {
        internal ActionMap map
        {
            get { return this["map"]; }
            set { this["map"] = value; }
        }

        [ConsoleInteraction]
        public void initialize()
        {
            ActionMap map = new ObjectCreator("ActionMap").Create();
            map.bindCmd("keyboard", "1", "EWorldEditorNoneModeBtn.performClick();", ""); // Select
            map.bindCmd("keyboard", "2", "EWorldEditorMoveModeBtn.performClick();", ""); // Move
            map.bindCmd("keyboard", "3", "EWorldEditorRotateModeBtn.performClick();", ""); // Rotate
            map.bindCmd("keyboard", "4", "EWorldEditorScaleModeBtn.performClick();", ""); // Scale

            this.map = map;

            new ObjectCreator("ScriptObject", "ParticleEditor", typeof (ParticleEditor)).Create();

            new ObjectCreator("PersistenceManager", "PE_EmitterSaver").Create();
            new ObjectCreator("PersistenceManager", "PE_ParticleSaver").Create();

            new ObjectCreator("SimSet", "PE_UnlistedParticles").Create();
            new ObjectCreator("SimSet", "PE_UnlistedEmitters").Create();
        }

        [ConsoleInteraction]
        public override void onWorldEditorStartup()
        {
            EditorGui EditorGui = "EditorGui";

            // Add ourselves to the window menu.
            string accel = EditorGui.addToEditorsMenu("Particle Editor", "", this);

            // Add ourselves to the ToolsToolbar
            string tooltip = "Particle Editor (" + accel + ")";
            EditorGui.addToToolsToolbar("ParticleEditorPlugin", "ParticleEditorPalette", Util._expandFilename("tools/worldEditor/images/toolbar/particleeditor"), tooltip);
        }

        //---------------------------------------------------------------------------------------------
        [ConsoleInteraction]
        public override void onActivated()
        {
            ParticleEditor ParticleEditor = "ParticleEditor";
            EditorGui EditorGui = "EditorGui";
            EditorGui.EditorGuiStatusBar EditorGuiStatusBar = "EditorGuiStatusBar";
            ParticleEditor.PE_Window PE_Window = "PE_Window";

            GuiControl WorldEditorToolbar = EditorGui.FOT("WorldEditorToolbar");

            //Copyright Winterleaf Entertainment L.L.C. 2013
            this["isActive"] = true.AsString();
            //Copyright Winterleaf Entertainment L.L.C. 2013
            if (!ParticleEditor["isInitialized"].AsBool())
                {
                ParticleEditor.initEditor();
                ParticleEditor["isInitialized"] = true.AsString();
                }

            WorldEditorToolbar.setVisible(true);
            EditorGui.bringToFront(PE_Window);
            PE_Window.setVisible(true);
            PE_Window.makeFirstResponder(true);

            this.map.push();

            ParticleEditor.resetEmitterNode();

            // Set the status bar here
            EditorGuiStatusBar.setInfo("Particle editor.");
            EditorGuiStatusBar.setSelection("");

            base.onActivated();
        }

        //---------------------------------------------------------------------------------------------
        [ConsoleInteraction]
        public override void onDeactivated()
        {
            EditorGui EditorGui = "EditorGui";
            ParticleEditor.PE_Window PE_Window = "PE_Window";

            GuiControl WorldEditorToolbar = EditorGui.FOT("WorldEditorToolbar");

            //Copyright Winterleaf Entertainment L.L.C. 2013
            if (!this["isActive"].AsBool())
                return;
            this["isActive"] = false.AsString();
            //Copyright Winterleaf Entertainment L.L.C. 2013  
            WorldEditorToolbar.setVisible(false);
            PE_Window.setVisible(false);

            if (sGlobal["$ParticleEditor::emitterNode"].isObject())
                sGlobal["$ParticleEditor::emitterNode"].delete();

            this.map.pop();

            base.onDeactivated();
        }

        //---------------------------------------------------------------------------------------------
        [ConsoleInteraction]
        public override void onExitMission()
        {
            ParticleEditor ParticleEditor = "ParticleEditor";

            // Force Particle Editor to re-initialize.
            ParticleEditor["isInitialized"] = false.AsString();

            base.onExitMission();
        }

        //---------------------------------------------------------------------------------------------
        [ConsoleInteraction]
        public void initSettings()
        {
            Settings EditorSettings = "EditorSettings";

            EditorSettings.beginGroup("ParticleEditor", true);

            EditorSettings.setDefaultValue("selectedTab", "0");

            EditorSettings.endGroup();
        }

        //---------------------------------------------------------------------------------------------
        [ConsoleInteraction]
        public void readSettings()
        {
            Settings EditorSettings = "EditorSettings";
            GuiPopUpMenuCtrl PEE_EmitterSelector = "PEE_EmitterSelector";
            ParticleEditor.PE_TabBook PE_TabBook = "PE_TabBook";
            GuiPopUpMenuCtrl PEP_ParticleSelector = "PEP_ParticleSelector";

            EditorSettings.beginGroup("ParticleEditor", true);

            string selectedEmitter = EditorSettings.value("selectedEmitter");
            if (selectedEmitter.isObject())
                PEE_EmitterSelector.setSelected(selectedEmitter.getID());

            string selectedParticle = EditorSettings.value("selectedParticle");
            if (selectedParticle.isObject())
                PEP_ParticleSelector.setSelected(selectedParticle.getID());

            PE_TabBook.selectPage(EditorSettings.value("selectedPage").AsInt());

            EditorSettings.endGroup();
        }

        //---------------------------------------------------------------------------------------------
        [ConsoleInteraction]
        public void writeSettings()
        {
            Settings EditorSettings = "EditorSettings";
            GuiPopUpMenuCtrl PEE_EmitterSelector = "PEE_EmitterSelector";
            ParticleEditor.PE_TabBook PE_TabBook = "PE_TabBook";
            GuiPopUpMenuCtrl PEP_ParticleSelector = "PEP_ParticleSelector";

            EditorSettings.beginGroup("ParticleEditor", true);

            EditorSettings.setValue("selectedEmitter", PEE_EmitterSelector.getText());
            EditorSettings.setValue("selectedParticle", PEP_ParticleSelector.getText());
            EditorSettings.setValue("selectedTab", PE_TabBook.getSelectedPage().AsString());

            EditorSettings.endGroup();
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ParticleEditorPlugin ts, string simobjectid)
        {
            return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ParticleEditorPlugin ts, string simobjectid)
        {
            if (ReferenceEquals(ts, null))
                return !ReferenceEquals(simobjectid, null);
            return !ts.Equals(simobjectid);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator string(ParticleEditorPlugin ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ParticleEditorPlugin(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ParticleEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (ParticleEditorPlugin));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ParticleEditorPlugin ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ParticleEditorPlugin(int simobjectid)
        {
            return (ParticleEditorPlugin) Omni.self.getSimObject((uint) simobjectid, typeof (ParticleEditorPlugin));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ParticleEditorPlugin ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ParticleEditorPlugin(uint simobjectid)
        {
            return (ParticleEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (ParticleEditorPlugin));
        }

        #endregion
    }
}