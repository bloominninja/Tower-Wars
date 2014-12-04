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
using LaughingDogStudios.Salvage.Logic.Models.User.GameCode.Client.Gui;
using LaughingDogStudios.Salvage.Logic.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.PlugIns;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace LaughingDogStudios.Salvage.Logic.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind
{
    [TypeConverter(typeof (TypeConverterGeneric<TerrainPainter>))]
    public class TerrainPainter : GuiWindowCollapseCtrl
    {
        public string filter
        {
            get { return this["filter"]; }
            set { this["filter"] = value; }
        }

        public override void onPopWindow()
        {
            TerrainPainterPlugin TerrainPainterPlugin = "TerrainPainterPlugin";

            EditorGui.DeactivateAll();
            TerrainPainterPlugin.onActivated();
        }

        public override void onPopWindowClosed()
        {
            TerrainPainterPlugin TerrainPainterPlugin = "TerrainPainterPlugin";
            GuiWindowCollapseCtrl TerrainPainterPreview = "TerrainPainterPreview";
            EditorGui.DeactivateAll();
            TerrainPainterPlugin.onActivated();
            this.attachTo(TerrainPainterPreview);
        }

        [ConsoleInteraction]
        public void updateLayers(string matIndex)
        {
            TerrainEditor ETerrainEditor = "ETerrainEditor";
            SimSet TerrainMaterialSet = "TerrainMaterialSet";

            // Default to whatever was selected before.
            if (matIndex == "")
                matIndex = ETerrainEditor.paintIndex.AsString();
            else
                ETerrainEditor.paintIndex = matIndex.AsInt(); //TerrainPainterAddition

            // The material string is a newline seperated string of
            // TerrainMaterial internal names which we can use to find
            // the actual material data in TerrainMaterialSet.

            string mats = ETerrainEditor.getMaterials();

            GuiStackControl matList = this.findObjectByInternalName("theMaterialList", true);
            matList.deleteAllObjects();

            string listWidth = matList.getExtent().x.AsString();

            for (int i = 0; i < Util.getRecordCount(mats); i++)
                {
                string matInternalName = Util.getRecord(mats, i);
                TerrainMaterial mat = TerrainMaterialSet.findObjectByInternalName(matInternalName, true);
                // Is there no material info for this slot?

                if (!mat.isObject())
                    continue;

                //if( this.filter != "" )
                //{
                //    if( Util.strstr( Util.strlwr(matInternalName), Util.strlwr(this.filter) ) == -1 )
                //        continue;
                //}

                ////TerrainPainterAddition
                //string terrainFolder = mat["terrainFolder"];
                //if( terrainFolder == "" )
                //    terrainFolder = "Unused";

                //string rolloutName = terrainFolder + "Rollout";
                //GuiRolloutCtrl rollout = matList.FOT(rolloutName);
                //GuiStackControl stack = "";
                //if( !rollout.isObject() )
                //{
                //    ObjectCreator ocRollout = new ObjectCreator("GuiRolloutCtrl");
                //    ocRollout["caption"] = terrainFolder;
                //    ocRollout["extent"] = listWidth + " " + "0";
                //    ocRollout["internalName"] = rolloutName;

                //    rollout = ocRollout.Create();

                //    ObjectCreator ocStack = new ObjectCreator("GuiStackControl");
                //    ocStack["StackingType"] = "Vertical";
                //    ocStack["HorizStacking"] = "Left to Right";
                //    ocStack["VertStacking"] = "Top to Bottom";
                //    ocStack["Padding"] = "-2";
                //    ocStack["canSaveDynamicFields"] = "0";
                //    ocStack["Enabled"] = "1";
                //    ocStack["isContainer"] = "1";
                //    ocStack["Profile"] = "ToolsGuiDefaultProfile";
                //    ocStack["HorizSizing"] = "width";
                //    ocStack["VertSizing"] = "bottom";
                //    ocStack["Position"] = "1 3";
                //    ocStack["Extent"] = listWidth + "" + "16";
                //    ocStack["MinExtent"] = "16 16";
                //    ocStack["canSave"] = "1";
                //    ocStack["isDecoy"] = "0";
                //    ocStack["Visible"] = "1";
                //    ocStack["internalName"] = "stackControl";
                //    ocStack["tooltipprofile"] = "ToolsGuiToolTipProfile";
                //    ocStack["hovertime"] = "1000";

                //    stack = ocStack.Create();

                //    rollout.add(stack);         

                //    matList.add(rollout);
                //}
                //else
                //{
                //    stack = rollout.FOT("stackControl");
                //}

                //int index = matList.getCount();

                string command = "ETerrainEditor.setPaintMaterial( " + i + ", " + mat + " );TerrainPainter.removeOtherSelections($ThisControl);TerrainPainter.lastActiveButton = $ThisControl;";
                string altCommand = "TerrainMaterialDlg.show( " + i + ", " + mat + ", EPainter_TerrainMaterialUpdateCallback );";

                ObjectCreator oc = new ObjectCreator("GuiIconButtonCtrl", "", typeof (EPainterIconBtn));
                //oc["class"] = "EPainterIconBtn";
                oc["internalName"] = "EPainterMaterialButton" + i;
                oc["profile"] = "GuiCreatorIconButtonProfile";
                oc["iconLocation"] = "Left";
                oc["textLocation"] = "Right";
                oc["extent"] = listWidth + " 46";
                oc["textMargin"] = 5;
                oc["buttonMargin"] = "4 4";
                oc["buttonType"] = "RadioButton";
                oc["sizeIconToButton"] = true;
                oc["makeIconSquare"] = true;
                oc["tooltipprofile"] = "ToolsGuiToolTipProfile";
                oc["command"] = command;
                oc["altCommand"] = altCommand;
                oc["useMouseEvents"] = true;

                ObjectCreator oc1 = new ObjectCreator("GuiBitmapButtonCtrl");
                oc1["bitmap"] = "tools/gui/images/delete";
                oc1["buttonType"] = "PushButton";
                oc1["HorizSizing"] = "left";
                oc1["VertSizing"] = "bottom";
                oc1["position"] = (listWidth.AsInt() - 20) + " 26";
                oc1["Extent"] = "17 17";
                //Copyright Winterleaf Entertainment L.L.C. 2013
                oc1["command"] = "TerrainPainter.showMaterialDeleteDlg( " + matInternalName + " );";
                //Copyright Winterleaf Entertainment L.L.C. 2013

                oc["#1"] = oc1;

                EPainterIconBtn ctrl = oc.Create();

                ctrl.setText(matInternalName);
                ctrl.setBitmap(mat.diffuseMap);

                string tooltip = matInternalName;

                if (i < 9)
                    tooltip = tooltip + " (" + (i + 1) + ")";
                else if (i == 9)
                    tooltip = tooltip + " (0)";

                ctrl.tooltip = tooltip;

                //stack.add(ctrl);
                matList.add(ctrl);
                }

            //int matCount = ETerrainEditor.getMaterialCount();
            int matCount = matList.getCount();
            // Add one more layer as the 'add new' layer.
            ObjectCreator ocb = new ObjectCreator("GuiIconButtonCtrl");
            ocb["profile"] = "GuiCreatorIconButtonProfile";
            ocb["iconBitmap"] = "tools/worldEditor/images/terrainpainter/new_layer_icon";
            ocb["iconLocation"] = "Left";
            ocb["textLocation"] = "Right";
            ocb["extent"] = listWidth + " 46";
            ocb["textMargin"] = 5;
            ocb["buttonMargin"] = "4 4";
            ocb["buttonType"] = "PushButton";
            ocb["sizeIconToButton"] = true;
            ocb["makeIconSquare"] = true;
            ocb["tooltipprofile"] = "ToolsGuiToolTipProfile";
            ocb["text"] = "New Layer";
            ocb["tooltip"] = "New Layer";
            ocb["command"] = "TerrainMaterialDlg.show( " + matCount + ", 0, EPainter_TerrainMaterialAddCallback );";
            GuiIconButtonCtrl ictrl = ocb.Create();
            matList.add(ictrl);

            // Make sure our selection is valid and that we're
            // not selecting the 'New Layer' button.

            if (matIndex.AsInt() < 0)
                return;
            if (matIndex.AsInt() >= matCount)
                matIndex = "0";

            // To make things simple... click the paint material button to
            // active it and initialize other state.

            ictrl = matList.getObject(matIndex.AsUint());
            //ictrl = matList.findObjectByInternalName("EPainterMaterialButton" + matIndex, true);

            ictrl.call("performClick");
        }

        //TerrainPainterAddition
        [ConsoleInteraction]
        public void removeOtherSelections(EPainterIconBtn currentCtrl)
        {
            if (this["lastActiveButton"].isObject() && this["lastActiveButton"] != currentCtrl)
                {
                if (((GuiIconButtonCtrl) this["lastActiveButton"]).getParent() != currentCtrl.getParent())
                    ((GuiIconButtonCtrl) this["lastActiveButton"]).setStateOn(false);
                }
        }

        //TerrainPainterAddition

        [ConsoleInteraction]
        public void showMaterialDeleteDlg(string matInternalName)
        {
            messageBox.MessageBoxYesNo("Confirmation", "Really remove material '" + matInternalName + "' from the terrain?", this + ".removeMaterial( \"" + matInternalName + "\" );", "");
        }

        [ConsoleInteraction]
        public void removeMaterial(string matInternalName)
        {
            TerrainEditor ETerrainEditor = "ETerrainEditor";

            int selIndex = ETerrainEditor.paintIndex - 1;

            // Remove the material from the terrain.

            int index = ETerrainEditor.getMaterialIndex(matInternalName);

            if (index != -1)
                ETerrainEditor.removeMaterial(index);

            this.updateLayers(selIndex.AsString());
        }

        [ConsoleInteraction]
        public void setup(int matIndex)
        {
            this.updateLayers(matIndex.AsString());
            TerrainEditor ETerrainEditor = "ETerrainEditor";
            ETerrainEditor["currentMode"] = "paint";
            ETerrainEditor.selectionHidden = true;
            ETerrainEditor.currentAction = "paintMaterial";
            ETerrainEditor["currentActionDesc"] = "Paint material on terrain";
            ETerrainEditor.setAction(ETerrainEditor.currentAction);
            ((EditorGui.EditorGuiStatusBar) "EditorGuiStatusBar").setInfo(ETerrainEditor["currentActionDesc"]);
            ETerrainEditor.renderVertexSelection = true;
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(TerrainPainter ts, string simobjectid)
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
        public static bool operator !=(TerrainPainter ts, string simobjectid)
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
        public static implicit operator string(TerrainPainter ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator TerrainPainter(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (TerrainPainter) Omni.self.getSimObject(simobjectid, typeof (TerrainPainter));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(TerrainPainter ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator TerrainPainter(int simobjectid)
        {
            return (TerrainPainter) Omni.self.getSimObject((uint) simobjectid, typeof (TerrainPainter));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(TerrainPainter ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator TerrainPainter(uint simobjectid)
        {
            return (TerrainPainter) Omni.self.getSimObject(simobjectid, typeof (TerrainPainter));
        }

        #endregion

        public class TerrainSelectorClearButton : GuiBitmapButtonCtrl
        {
            [ConsoleInteraction]
            public override void onClick(string SelectedidString)
            {
                ((TerrainSelectorTextEdit) this["textCtrl"]).reset();
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(TerrainSelectorClearButton ts, string simobjectid)
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
            public static bool operator !=(TerrainSelectorClearButton ts, string simobjectid)
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
            public static implicit operator string(TerrainSelectorClearButton ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator TerrainSelectorClearButton(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (TerrainSelectorClearButton) Omni.self.getSimObject(simobjectid, typeof (TerrainSelectorClearButton));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(TerrainSelectorClearButton ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator TerrainSelectorClearButton(int simobjectid)
            {
                return (TerrainSelectorClearButton) Omni.self.getSimObject((uint) simobjectid, typeof (TerrainSelectorClearButton));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(TerrainSelectorClearButton ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator TerrainSelectorClearButton(uint simobjectid)
            {
                return (TerrainSelectorClearButton) Omni.self.getSimObject(simobjectid, typeof (TerrainSelectorClearButton));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<TerrainSelectorTextEdit>))]
        public class TerrainSelectorTextEdit : GuiTextEditCtrl
        {
            [ConsoleInteraction]
            public override void onReturn()
            {
                TerrainEditor ETerrainEditor = "ETerrainEditor";

                TerrainPainter TerrainPainter = "TerrainPainter";
                string text = this.getText();
                if (text == "")
                    this.reset();
                else
                    {
                    TerrainPainter.filter = text;
                    TerrainPainter.updateLayers(ETerrainEditor.paintIndex.AsString());
                    }
            }

            //TerrainPainterAddition
            [ConsoleInteraction]
            public void reset()
            {
                TerrainEditor ETerrainEditor = "ETerrainEditor";

                TerrainPainter TerrainPainter = "TerrainPainter";
                this.setText("Filter...");
                TerrainPainter.filter = "";
                TerrainPainter.updateLayers(ETerrainEditor.paintIndex.AsString());
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(TerrainSelectorTextEdit ts, string simobjectid)
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
            public static bool operator !=(TerrainSelectorTextEdit ts, string simobjectid)
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
            public static implicit operator string(TerrainSelectorTextEdit ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator TerrainSelectorTextEdit(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (TerrainSelectorTextEdit) Omni.self.getSimObject(simobjectid, typeof (TerrainSelectorTextEdit));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(TerrainSelectorTextEdit ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator TerrainSelectorTextEdit(int simobjectid)
            {
                return (TerrainSelectorTextEdit) Omni.self.getSimObject((uint) simobjectid, typeof (TerrainSelectorTextEdit));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(TerrainSelectorTextEdit ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator TerrainSelectorTextEdit(uint simobjectid)
            {
                return (TerrainSelectorTextEdit) Omni.self.getSimObject(simobjectid, typeof (TerrainSelectorTextEdit));
            }

            #endregion
        }

    }
}