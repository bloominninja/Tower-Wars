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

namespace LaughingDogStudios.Salvage.Logic.Models.User.GameCode.Tools.DecalEditor.gui.CodeBehind
{
    [TypeConverter(typeof (TypeConverterGeneric<DecalEditorPlugin>))]
    public class DecalEditorPlugin : EditorPlugin
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
            map.bindCmd("keyboard", "5", "EDecalEditorAddDecalBtn.performClick();", "");
            map.bindCmd("keyboard", "1", "EDecalEditorSelectDecalBtn.performClick();", "");
            map.bindCmd("keyboard", "2", "EDecalEditorMoveDecalBtn.performClick();", "");
            map.bindCmd("keyboard", "3", "EDecalEditorRotateDecalBtn.performClick();", "");
            map.bindCmd("keyboard", "4", "EDecalEditorScaleDecalBtn.performClick();", "");

            this.map = map;

            new ObjectCreator("PersistenceManager", "DecalPMan").Create();
        }

        [ConsoleInteraction]
        public override void onWorldEditorStartup()
        {
            EditorGui EditorGui = "EditorGui";
            GuiWindowCollapseCtrl DecalPreviewWindow = "DecalPreviewWindow";
            GuiWindowCollapseCtrl DecalEditorWindow = "DecalEditorWindow";

            // Add ourselves to the window menu.
            string accel = EditorGui.addToEditorsMenu("Decal Editor", "", "DecalEditorPlugin");

            // Add ourselves to the ToolsToolbar
            string tooltip = "Decal Editor (" + accel + ")";
            EditorGui.addToToolsToolbar("DecalEditorPlugin", "DecalEditorPalette", Util._expandFilename("tools/decalEditor/decal-editor"), tooltip);

            //connect editor windows   
            DecalPreviewWindow.attachTo(DecalEditorWindow);

            //set initial palette setting
            this["paletteSelection"] = "AddDecalMode";
        }

        [ConsoleInteraction]
        public override void onActivated()
        {
            DecalEditorGui DecalEditorGui = "DecalEditorGui";
            EditorGui EditorGui = "EditorGui";
            GuiWindowCollapseCtrl DecalPreviewWindow = "DecalPreviewWindow";
            GuiWindowCollapseCtrl DecalEditorWindow = "DecalEditorWindow";
            GizmoProfile GlobalGizmoProfile = "GlobalGizmoProfile";

            //Copyright Winterleaf Entertainment L.L.C. 2013
            this["isActive"] = true.AsString();
            //Copyright Winterleaf Entertainment L.L.C. 2013   
            EditorGui.bringToFront(DecalEditorGui);
            DecalEditorGui.setVisible(true);
            DecalEditorGui.makeFirstResponder(true);
            DecalPreviewWindow.setVisible(true);
            DecalEditorWindow.setVisible(true);

            this.map.push();

            //WORKAROUND: due to the gizmo mode being stored on its profile (which may be shared),
            //  we may end up with a mismatch between the editor mode and gizmo mode here.
            //  Reset mode explicitly here to work around this.
            DecalEditorGui.setMode(DecalEditorGui.getMode());

            // Set the current palette selection
            DecalEditorGui.paletteSync(this["paletteSelection"]);

            // Store this on a dynamic field
            // in order to restore whatever setting
            // the user had before.
            this["prevGizmoAlignment"] = GlobalGizmoProfile["alignment"];

            // The DecalEditor always uses Object alignment.
            GlobalGizmoProfile["alignment"] = "Object";

            DecalEditorGui.rebuildInstanceTree();

            // These could perhaps be the node details like the shape editor
            //ShapeEdPropWindow.syncNodeDetails(-1);

            base.onActivated();
        }

        [ConsoleInteraction]
        public override void onDeactivated()
        {
            DecalEditorGui DecalEditorGui = "DecalEditorGui";
            GuiWindowCollapseCtrl DecalPreviewWindow = "DecalPreviewWindow";
            GuiWindowCollapseCtrl DecalEditorWindow = "DecalEditorWindow";
            GizmoProfile GlobalGizmoProfile = "GlobalGizmoProfile";

            //Copyright Winterleaf Entertainment L.L.C. 2013
            if (!this["isActive"].AsBool())
                return;
            this["isActive"] = false.AsString();
            //Copyright Winterleaf Entertainment L.L.C. 2013   
            DecalEditorGui.setVisible(false);
            DecalPreviewWindow.setVisible(false);
            DecalEditorWindow.setVisible(false);

            this.map.pop();

            // Remember last palette selection
            this["paletteSelection"] = DecalEditorGui.getMode();

            // Restore the previous Gizmo
            // alignment settings.
            GlobalGizmoProfile["alignment"] = this["prevGizmoAlignment"];

            base.onDeactivated();
        }

        [ConsoleInteraction]
        public override bool isDirty()
        {
            PersistenceManager DecalPMan = "DecalPMan";
            bool dirty = DecalPMan.hasDirty();

            dirty |= Util.decalManagerDirty();
            return dirty;
        }

        [ConsoleInteraction]
        public override void onSaveMission(string missionFile)
        {
            PersistenceManager DecalPMan = "DecalPMan";

            DecalPMan.saveDirty();
            Util.decalManagerSave(missionFile + ".decals");
        }

        [ConsoleInteraction]
        public override void onEditMenuSelect(string editMenu)
        {
            DecalEditorGui DecalEditorGui = "DecalEditorGui";

            bool hasSelection = DecalEditorGui.getSelectionCount() > 0;

            ((PopupMenu) editMenu).enableItem(3, false); // Cut
            ((PopupMenu) editMenu).enableItem(4, false); // Copy
            ((PopupMenu) editMenu).enableItem(5, false); // Paste 
            ((PopupMenu) editMenu).enableItem(6, hasSelection); // Delete
            ((PopupMenu) editMenu).enableItem(8, false); // Deselect 

            // NOTE: If you want to implement Cut, Copy, Paste, or Deselect
            // for this editor simply enable the menu items when it is appropriate
            // and fill in the method stubs below.
        }

        [ConsoleInteraction]
        public override void handleDelete()
        {
            DecalEditorGui DecalEditorGui = "DecalEditorGui";
            DecalEditorGui.deleteSelectedDecal();
        }

        [ConsoleInteraction]
        public override void handleDeselect()
        {
        }

        [ConsoleInteraction]
        public override void handleCut()
        {
        }

        [ConsoleInteraction]
        public override void handleCopy()
        {
        }

        [ConsoleInteraction]
        public override void handlePaste()
        {
        }

        [ConsoleInteraction]
        public override bool handleEscape()
        {
            return true;
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(DecalEditorPlugin ts, string simobjectid)
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
        public static bool operator !=(DecalEditorPlugin ts, string simobjectid)
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
        public static implicit operator string(DecalEditorPlugin ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator DecalEditorPlugin(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (DecalEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (DecalEditorPlugin));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(DecalEditorPlugin ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator DecalEditorPlugin(int simobjectid)
        {
            return (DecalEditorPlugin) Omni.self.getSimObject((uint) simobjectid, typeof (DecalEditorPlugin));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(DecalEditorPlugin ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator DecalEditorPlugin(uint simobjectid)
        {
            return (DecalEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (DecalEditorPlugin));
        }

        #endregion
    }
}