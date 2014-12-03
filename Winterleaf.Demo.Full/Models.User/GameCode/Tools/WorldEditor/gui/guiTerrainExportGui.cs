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
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Enums;

namespace LaughingDogStudios.Salvage.Logic.Models.User.GameCode.Tools.WorldEditor.gui
{
    [TypeConverter(typeof (TypeConverterGeneric<guiTerrainExportGui>))]
    public class guiTerrainExportGui : GuiControl
    {
        [ConsoleInteraction(true, "guiTerrainExportGui_initialize")]
        public static void initialize()
        {
            #region GuiControl (TerrainExportGui, EditorGuiGroup)        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiControl", "TerrainExportGui, EditorGuiGroup", typeof (guiTerrainExportGui));
            oc_Newobject10["canSaveDynamicFields"] = "0";
            oc_Newobject10["Profile"] = "ToolsGuiOverlayProfile";
            oc_Newobject10["Enabled"] = "1";
            oc_Newobject10["isContainer"] = "1";
            oc_Newobject10["HorizSizing"] = "right";
            oc_Newobject10["VertSizing"] = "bottom";
            oc_Newobject10["Position"] = "0 0";
            oc_Newobject10["Extent"] = "1024 768";
            oc_Newobject10["MinExtent"] = "8 2";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["Visible"] = "1";
            oc_Newobject10["hovertime"] = "1000";

            #region GuiWindowCtrl (TerrainExportWindow)        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiWindowCtrl", "TerrainExportWindow");
            oc_Newobject9["profile"] = "ToolsGuiWindowProfile";
            oc_Newobject9["canSaveDynamicFields"] = "0";
            oc_Newobject9["internalName"] = "TerrainExport";
            oc_Newobject9["Enabled"] = "1";
            oc_Newobject9["isContainer"] = "1";
            oc_Newobject9["HorizSizing"] = "center";
            oc_Newobject9["VertSizing"] = "center";
            oc_Newobject9["Position"] = "248 248";
            oc_Newobject9["Extent"] = "290 235";
            oc_Newobject9["MinExtent"] = "8 2";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["Margin"] = "0 0 0 0";
            oc_Newobject9["Padding"] = "0 0 0 0";
            oc_Newobject9["AnchorTop"] = "1";
            oc_Newobject9["AnchorBottom"] = "1";
            oc_Newobject9["AnchorLeft"] = "1";
            oc_Newobject9["AnchorRight"] = "1";
            oc_Newobject9["resizeWidth"] = "0";
            oc_Newobject9["resizeHeight"] = "0";
            oc_Newobject9["canMove"] = "1";
            oc_Newobject9["canClose"] = "1";
            oc_Newobject9["canMinimize"] = "0";
            oc_Newobject9["canMaximize"] = "0";
            oc_Newobject9["minSize"] = "50 50";
            oc_Newobject9["closeCommand"] = "TerrainExportGui.close();";
            oc_Newobject9["EdgeSnap"] = "0";
            oc_Newobject9["canCollapse"] = "0";
            oc_Newobject9["text"] = "Export Terrain";

            #region GuiScrollCtrl (TerrainSelectScroll)        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiScrollCtrl", "TerrainSelectScroll");
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["Enabled"] = "1";
            oc_Newobject2["isContainer"] = "1";
            oc_Newobject2["HorizSizing"] = "right";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["Position"] = "9 43";
            oc_Newobject2["Extent"] = "272 112";
            oc_Newobject2["MinExtent"] = "8 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["willFirstRespond"] = "1";
            oc_Newobject2["hScrollBar"] = "alwaysOff";
            oc_Newobject2["vScrollBar"] = "dynamic";
            oc_Newobject2["lockHorizScroll"] = "true";
            oc_Newobject2["lockVertScroll"] = "false";
            oc_Newobject2["constantThumbHeight"] = "0";
            oc_Newobject2["childMargin"] = "0 0";

            #region GuiListBoxCtrl (TerrainSelectListBox)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiListBoxCtrl", "TerrainSelectListBox");
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["Enabled"] = "1";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["HorizSizing"] = "right";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["Position"] = "2 2";
            oc_Newobject1["Extent"] = "248 104";
            oc_Newobject1["MinExtent"] = "8 2";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["AllowMultipleSelections"] = "1";
            oc_Newobject1["fitParentWidth"] = "1";

            #endregion

            oc_Newobject2["#Newobject1"] = oc_Newobject1;

            #endregion

            oc_Newobject9["#Newobject2"] = oc_Newobject2;

            #region GuiTextCtrl (TerrainSelectText)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiTextCtrl", "TerrainSelectText");
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["Enabled"] = "1";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["HorizSizing"] = "right";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["Position"] = "9 25";
            oc_Newobject3["Extent"] = "88 16";
            oc_Newobject3["MinExtent"] = "8 2";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["Margin"] = "0 0 0 0";
            oc_Newobject3["Padding"] = "0 0 0 0";
            oc_Newobject3["AnchorTop"] = "1";
            oc_Newobject3["AnchorBottom"] = "0";
            oc_Newobject3["AnchorLeft"] = "1";
            oc_Newobject3["AnchorRight"] = "0";
            oc_Newobject3["text"] = "Select Terrain(s):";
            oc_Newobject3["maxLength"] = "1024";

            #endregion

            oc_Newobject9["#Newobject3"] = oc_Newobject3;

            #region GuiTextEditCtrl (SelectFolderTextEdit)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiTextEditCtrl", "SelectFolderTextEdit");
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["Enabled"] = "1";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["HorizSizing"] = "right";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["Position"] = "9 176";
            oc_Newobject4["Extent"] = "195 18";
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["Margin"] = "0 0 0 0";
            oc_Newobject4["Padding"] = "0 0 0 0";
            oc_Newobject4["AnchorTop"] = "1";
            oc_Newobject4["AnchorBottom"] = "0";
            oc_Newobject4["AnchorLeft"] = "1";
            oc_Newobject4["AnchorRight"] = "0";
            oc_Newobject4["maxLength"] = "1024";
            oc_Newobject4["historySize"] = "0";
            oc_Newobject4["password"] = "0";
            oc_Newobject4["tabComplete"] = "0";
            oc_Newobject4["sinkAllKeyEvents"] = "0";
            oc_Newobject4["passwordMask"] = "*";

            #endregion

            oc_Newobject9["#Newobject4"] = oc_Newobject4;

            #region GuiButtonCtrl (SelectFolderButton)        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiButtonCtrl", "SelectFolderButton");
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["Enabled"] = "1";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["Position"] = "212 174";
            oc_Newobject5["Extent"] = "69 22";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["Command"] = "TerrainExportGui.selectFolder();";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["text"] = "Browse";
            oc_Newobject5["groupNum"] = "-1";
            oc_Newobject5["buttonType"] = "PushButton";
            oc_Newobject5["useMouseEvents"] = "0";

            #endregion

            oc_Newobject9["#Newobject5"] = oc_Newobject5;

            #region GuiButtonCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["Enabled"] = "1";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["Position"] = "174 202";
            oc_Newobject6["Extent"] = "107 24";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["Command"] = "TerrainExportGui.close();";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["text"] = "Cancel";
            oc_Newobject6["groupNum"] = "-1";
            oc_Newobject6["buttonType"] = "PushButton";
            oc_Newobject6["useMouseEvents"] = "0";

            #endregion

            oc_Newobject9["#Newobject6"] = oc_Newobject6;

            #region GuiButtonCtrl (ExportButton)        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiButtonCtrl", "ExportButton");
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["Enabled"] = "1";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["HorizSizing"] = "right";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["Position"] = "9 202";
            oc_Newobject7["Extent"] = "107 24";
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["Command"] = "TerrainExportGui.export();";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["text"] = "Export";
            oc_Newobject7["groupNum"] = "-1";
            oc_Newobject7["buttonType"] = "PushButton";
            oc_Newobject7["useMouseEvents"] = "0";

            #endregion

            oc_Newobject9["#Newobject7"] = oc_Newobject7;

            #region GuiTextCtrl (FolderText)        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiTextCtrl", "FolderText");
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["Enabled"] = "1";
            oc_Newobject8["isContainer"] = "0";
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["Position"] = "9 159";
            oc_Newobject8["Extent"] = "96 16";
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["Margin"] = "0 0 0 0";
            oc_Newobject8["Padding"] = "0 0 0 0";
            oc_Newobject8["AnchorTop"] = "1";
            oc_Newobject8["AnchorBottom"] = "0";
            oc_Newobject8["AnchorLeft"] = "1";
            oc_Newobject8["AnchorRight"] = "0";
            oc_Newobject8["text"] = "Folder:";
            oc_Newobject8["maxLength"] = "1024";

            #endregion

            oc_Newobject9["#Newobject8"] = oc_Newobject8;

            #endregion

            oc_Newobject10["#Newobject9"] = oc_Newobject9;

            #endregion

            oc_Newobject10.Create();
        }

        /*

        function TerrainExportGui::findAllTerrains( %this )
        {
           TerrainSelectListBox.clearItems();

           if ( isObject( MegaTerrain ) )
              TerrainSelectListBox.addItem( "MegaTerrain" );

           // Find all of the terrain files
           initContainerTypeSearch( $TypeMasks::TerrainObjectType );

           while ( (%terrainObject = containerSearchNext()) != 0 )
           {
              %terrainId = %terrainObject.getId();
              %terrainName = %terrainObject.getName();
              if ( %terrainName $= "" )
                 %terrainName = "Unnamed (" @ %terrainId @ ")";

              TerrainSelectListBox.addItem( %terrainName, %terrainId );
           }
        }

         */

        [ConsoleInteraction]
        public void findAllTerrains()
        {
            GuiListBoxCtrl TerrainSelectListBox = "TerrainSelectListBox";
            TerrainSelectListBox.clearItems();

            if ("MegaTerrain".isObject())
                TerrainSelectListBox.addItem("MegaTerrain", "");
            // Find all of the terrain files

            Util.initContainerTypeSearch((uint) SceneObjectTypesAsUint.TerrainObjectType, false);

            string terrainObject = Util.containerSearchNext(false);
            while (terrainObject != "0")
                {
                uint terrainID = terrainObject.getUID();
                string terrainName = terrainObject.getName();
                if (terrainName == "")
                    terrainName = "Unnamed (" + terrainID + ")";
                TerrainSelectListBox.addItem(terrainName, terrainID.AsString());
                }
        }

        [ConsoleInteraction]
        public void init()
        {
            findAllTerrains();
        }

        /*
        function TerrainExportGui::export( %this )
        {
           %itemId = TerrainSelectListBox.getSelectedItem();
           %terrainObj = TerrainSelectListBox.getItemObject( %itemId );
           if ( !isObject( %terrainObj ) )
           {
              MessageBoxOK( "Export failed", "Could not find the selected TerrainBlock!" );
              return;
           }

           %filePath = SelectFolderTextEdit.getText();

           %terrainName = %terrainObj.getName();
           if ( %terrainName $= "" )
              %terrainName = "Unnamed";

           %fileName = %terrainName @ "_heightmap.png";
           %filePrefix = %terrainName @ "_layerMap";

           %ret = %terrainObj.exportHeightMap( %filePath @ "/" @ %fileName, "png" );
           if ( %ret )
              %ret = %terrainObj.exportLayerMaps( %filePath @ "/" @ %filePrefix, "png" );

           if ( %ret )
              %this.close();
        }
         * */

        [ConsoleInteraction]
        public void export()
        {
            GuiListBoxCtrl TerrainSelectListBox = "TerrainSelectListBox";
            int itemId = TerrainSelectListBox.getSelectedItem();
            TerrainBlock terrainObj = TerrainSelectListBox.getItemObject(itemId);
            if (!terrainObj.isObject())
                {
                messageBox.MessageBoxOK("Export failed", "Could not find the selected TerrainBlock!");
                return;
                }
            string filePath = ((GuiTextEditCtrl) "SelectFolderTextEdit").getText();
            string terrainName = terrainObj.getName();
            if (terrainName == "")
                terrainName = "Unnamed";

            string fileName = terrainName + "_heightmap.png";
            string filePrefix = terrainName + "_layerMap";

            string ret = terrainObj.call("exportHeightMap", new string[] {filePath + "/" + fileName, "png"});
            if (ret.AsBool())
                ret = terrainObj.call("exportLayerMaps", new string[] {filePath + "/" + filePrefix, "png"});

            if (ret.AsBool())
                close();
        }

        public override void onWake()
        {
            init();
        }

        [ConsoleInteraction]
        public void close()
        {
            ((GuiCanvas) "Canvas").popDialog(this);
        }

        [ConsoleInteraction]
        public void showExportDialog()
        {
            findAllTerrains();
            ((GuiCanvas) "Canvas").pushDialog(this);
        }

        [ConsoleInteraction]
        public void openFolderCallback(string path)
        {
            ((GuiTextEditCtrl) "SelectFolderTextEdit").setText(path);
        }

        [ConsoleInteraction]
        public void selectFolder()
        {
            doOpenDialog("", this + ".openFolderCallback");
        }

        /*
        function TerrainExportGui::doOpenDialog( %this, %filter, %callback )
        {
           %dlg = new OpenFolderDialog()
           {
              Title = "Select Export Folder";
              Filters = %filter;
              DefaultFile = %currentFile;
              ChangePath = false;
              MustExist = true;
              MultipleFiles = false;
           };

           if(filePath( %currentFile ) !$= "")
              %dlg.DefaultPath = filePath(%currentFile);
           else
              %dlg.DefaultPath = getMainDotCSDir();

           if(%dlg.Execute())
              eval(%callback @ "(\"" @ %dlg.FileName @ "\");");

           %dlg.delete();
        }
         */

        [ConsoleInteraction]
        public void doOpenDialog(string filter, string callback)
        {
            ObjectCreator oc = new ObjectCreator("OpenFolderDialog");
            oc["Title"] = "Select Export Folder";
            oc["Filters"] = filter;
            oc["DefaultFile"] = new Creator.StringNoQuote("$currentFile");
            oc["ChangePath"] = false;
            oc["MustExist"] = true;
            oc["MultipleFiles"] = false;

            OpenFolderDialog dlg = oc.Create();

            if (Util.filePath(sGlobal["$currentFile"]) != "")
                dlg["DefaultPath"] = Util.filePath(sGlobal["$currentFile"]);
            else
                dlg["DefaultPath"] = Util.getMainDotCsDir();

            if (dlg.Execute())
                Util.eval(callback + "(\"" + dlg["FileName"] + "\");");

            dlg.delete();
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(guiTerrainExportGui ts, string simobjectid)
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
        public static bool operator !=(guiTerrainExportGui ts, string simobjectid)
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
        public static implicit operator string(guiTerrainExportGui ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator guiTerrainExportGui(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (guiTerrainExportGui) Omni.self.getSimObject(simobjectid, typeof (guiTerrainExportGui));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(guiTerrainExportGui ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator guiTerrainExportGui(int simobjectid)
        {
            return (guiTerrainExportGui) Omni.self.getSimObject((uint) simobjectid, typeof (guiTerrainExportGui));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(guiTerrainExportGui ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator guiTerrainExportGui(uint simobjectid)
        {
            return (guiTerrainExportGui) Omni.self.getSimObject(simobjectid, typeof (guiTerrainExportGui));
        }

        #endregion
    }
}