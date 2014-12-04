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

using System.ComponentModel;
using LaughingDogStudios.Salvage.Logic.Models.User.Extendable;
using LaughingDogStudios.Salvage.Logic.Models.User.GameCode.Tools.Base.Utils;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

#endregion

namespace LaughingDogStudios.Salvage.Logic.Models.User.GameCode.Tools.WorldEditor
{
    [TypeConverter(typeof (TypeConverterGeneric<Inspector>))]
    public class Inspector : EditorInspectorBase
    {
        internal UndoAction currentFieldEditAction
        {
            get { return this["currentFieldEditAction"]; }
            set { this["currentFieldEditAction"] = value; }
        }

        [ConsoleInteraction]
        public override void onInspectorFieldModified(string objectx, string fieldName, string arrayIndex, string oldValue, string newValue)
        {
            SimObject obj = objectx;
            editor Editor = "Editor";
            // The instant group will try to add our
            // UndoAction if we don't disable it.  
            Util.pushInstantGroup();

            string nameOrClass = obj.getName();

            if (nameOrClass == "")
                nameOrClass = obj.getClassName();

            ObjectCreator oc = new ObjectCreator("InspectorFieldUndoAction");
            oc["actionName"] = nameOrClass + "." + fieldName + " Change";
            oc["objectId"] = obj.getId();
            oc["fieldName"] = fieldName;
            oc["fieldValue"] = oldValue;
            oc["arrayIndex"] = arrayIndex;
            oc["inspectorGui"] = this;
            InspectorFieldUndoAction action = oc.Create();

            // If it's a datablock, initiate a retransmit.  Don't do so
            // immediately so as the actual field value will only be set
            // by the inspector code after this method has returned.

            if (obj.isMemberOfClass("SimDataBlock"))
                obj.schedule("1", "reloadOnLocalClient");

            // Restore the instant group.
            Util.popInstantGroup();

            action.addToManager(Editor.getUndoManager());

            EWorldEditor EWorldEditor = "EWorldEditor";

            EWorldEditor.isDirty = true;

            // Update the selection
            if (EWorldEditor.getSelectionSize() > 0 && (fieldName == "position" || fieldName == "rotation" || fieldName == "scale"))
                EWorldEditor.invalidateSelectionCentroid();
        }

        [ConsoleInteraction]
        public override void onFieldSelected(string fieldName, string fieldTypeStr, string fieldDoc)
        {
            ((GuiMLTextCtrl) "FieldInfoControl").setText("<font:ArialBold:14>" + fieldName + "<font:ArialItalic:14> (" + fieldTypeStr + ") \r\n<font:Arial:14>" + fieldDoc);
        }

        [ConsoleInteraction]
        public void onInspectorPreFieldModification(string fieldName, string arrayIndex)
        {
            Util.pushInstantGroup();
            editor Editor = "Editor";

            UndoManager undoManager = Editor.getUndoManager();

            int numOfObjects = this.getNumInspectObjects();

            UndoAction action = "0";
            if (numOfObjects > 1)
                action = undoManager.pushCompound("Multiple Field Edit");

            for (uint i = 0; i < numOfObjects; i++)
                {
                SimObject obj = getInspectObject(i);

                string nameOrClass = obj.getName();

                if (nameOrClass == "")
                    nameOrClass = obj.getClassName();

                ObjectCreator oc = new ObjectCreator("InspectorFieldUndoAction");
                oc["actionName"] = nameOrClass + "." + fieldName + " Change";
                oc["objectId"] = obj.getId();
                oc["fieldName"] = fieldName;
                oc["fieldValue"] = obj.getFieldValue(fieldName, arrayIndex == "(null)" ? -1 : arrayIndex.AsInt());
                oc["arrayIndex"] = arrayIndex;
                oc["inspectorGui"] = this;

                InspectorFieldUndoAction undo = oc.Create();

                if (numOfObjects > 1)
                    undo.addToManager(undoManager);
                else
                    {
                    action = undo;
                    break;
                    }
                }
            this["currentFieldEditAction"] = action;
            Util.popInstantGroup();
        }

        [ConsoleInteraction]
        public void onInspectorPostFieldModification()
        {
            editor Editor = "Editor";
            if (currentFieldEditAction.isMemberOfClass("CompoundUndoAction"))
                Editor.getUndoManager().popCompound();
            else
                currentFieldEditAction.addToManager(Editor.getUndoManager());

            currentFieldEditAction = "";

            ((EWorldEditor) "EWorldEditor").isDirty = true;
        }

        [ConsoleInteraction]
        public void onInspectorDiscardFieldModification()
        {
            editor Editor = "Editor";
            currentFieldEditAction.undo();

            if (currentFieldEditAction.isMemberOfClass("CompoundUndoAction"))
                Editor.getUndoManager().popCompound(true);
            else
                currentFieldEditAction.delete();

            this.currentFieldEditAction = "";
        }

        [ConsoleInteraction]
        public void inspect(SimObject obj)
        {
            string name = "";
            if (obj.isObject())
                name = obj.getName();
            else
                ((GuiMLTextCtrl) "FieldInfoControl").setText("");

            base.inspect(obj);
        }

        [ConsoleInteraction]
        public override void onBeginCompoundEdit()
        {
            editor Editor = "Editor";
            Editor.getUndoManager().pushCompound("Multiple Field Edit");
        }

        [ConsoleInteraction]
        public override void onEndCompoundEdit()
        {
            editor Editor = "Editor";
            Editor.getUndoManager().popCompound();
        }

        [ConsoleInteraction]
        public virtual void onCancelCompoundEdit()
        {
            editor Editor = "Editor";
            Editor.getUndoManager().popCompound(true);
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(Inspector ts, string simobjectid)
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
        public static bool operator !=(Inspector ts, string simobjectid)
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
        public static implicit operator string(Inspector ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator Inspector(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (Inspector) Omni.self.getSimObject(simobjectid, typeof (Inspector));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(Inspector ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator Inspector(int simobjectid)
        {
            return (Inspector) Omni.self.getSimObject((uint) simobjectid, typeof (Inspector));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(Inspector ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator Inspector(uint simobjectid)
        {
            return (Inspector) Omni.self.getSimObject(simobjectid, typeof (Inspector));
        }

        #endregion
    }
}