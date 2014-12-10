

// WinterLeaf Entertainment
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
using LaughingDogStudios.Salvage.Logic.Models.User.GameCode.Client.Gui.ChooseLevel;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace LaughingDogStudios.Salvage.Logic.Models.User.GameCode.Client.Gui
{
    [TypeConverter(typeof(TypeConverterGeneric<mainMenuGui>))]
    public class mainMenuGui : GuiChunkedBitmapCtrl
    {
        public static void initialize()
        {
            ObjectCreator QuitTabButton;
            ObjectCreator UpdatesTabButton;
            ObjectCreator DevTabButton;
            ObjectCreator PrivateTabButton;
            ObjectCreator MatchmakingTabButton;
            ObjectCreator StoreTabButton;
            ObjectCreator OptionsTabButton;
            ObjectCreator CommunityTabButton;
            ObjectCreator ServerTabButton;

            ObjectCreator ButtonsSection;
            ObjectCreator ButtonsSectionBg;

            ObjectCreator WorldEditorButton;
            ObjectCreator GuiEditorButton;

            ObjectCreator OptionsBody;
            ObjectCreator OptionsBodyText;
            ObjectCreator OptionsTab;

            ObjectCreator DevBody;
            ObjectCreator DevBodyText;
            ObjectCreator DevTab;

            ObjectCreator ServerBody;
            ObjectCreator ServerBodyText;
            ObjectCreator ServerTab;

            ObjectCreator CommunityBody;
            ObjectCreator CommunityBodyText;
            ObjectCreator CommunityTab;

            ObjectCreator PrivateBody;
            ObjectCreator PrivateBodyText;
            ObjectCreator PrivateTab;

            ObjectCreator MatchmakingBody;
            ObjectCreator MatchmakingBodyText;
            ObjectCreator MatchmakingTab;

            ObjectCreator StoreBody;
            ObjectCreator StoreBodyText;
            ObjectCreator StoreTab;

            ObjectCreator UpdatesBody;
            ObjectCreator UpdatesBodyText;
            ObjectCreator UpdatesTab;

            ObjectCreator ContentTitle;
            ObjectCreator ContentPanelBg;
            ObjectCreator ContentPanelRight;
            ObjectCreator ContentPanelLeft;
            ObjectCreator ContentSection;
            ObjectCreator MenuItemHolder;
            ObjectCreator LogoImage;
            ObjectCreator BackgroundImage;
            ObjectCreator oc_Newobject00021;
            ObjectCreator oc_Newobject00020;
            ObjectCreator oc_Newobject00019;
            ObjectCreator oc_Newobject00018;
            ObjectCreator oc_Newobject00017;
            ObjectCreator oc_Newobject00016;
            ObjectCreator oc_Newobject00015;
            ObjectCreator oc_Newobject00014;
            ObjectCreator oc_Newobject00013;
            ObjectCreator oc_Newobject00012;
            ObjectCreator oc_Newobject00011;
            ObjectCreator oc_Newobject00010;
            ObjectCreator oc_Newobject00009;
            ObjectCreator oc_Newobject00008;
            ObjectCreator oc_Newobject00007;
            ObjectCreator oc_Newobject00006;
            ObjectCreator oc_Newobject00004;
            ObjectCreator oc_Newobject00002;
            ObjectCreator oc_Newobject00001;
            if (true)
            {
                #region GuiChunkedBitmapCtrl (MainMenuGui)        oc_Newobject00022

                BackgroundImage = new ObjectCreator("GuiChunkedBitmapCtrl", "MainMenuGui", typeof(mainMenuGui));
                BackgroundImage = new ObjectCreator("GuiChunkedBitmapCtrl", "MainMenuGui");
                BackgroundImage["bitmap"] = "art/gui/launcher/bg.png";
                BackgroundImage["useVariable"] = "0";
                BackgroundImage["tile"] = "0";
                BackgroundImage["position"] = "0 0";
                BackgroundImage["extent"] = "1024 768";
                BackgroundImage["minExtent"] = "8 8";
                BackgroundImage["maxExtent"] = "1920 1080";
                BackgroundImage["horizSizing"] = "left";
                BackgroundImage["vertSizing"] = "top";
                BackgroundImage["profile"] = "GuiDefaultProfile";
                BackgroundImage["controlFontColor"] = "0 0 0 0";
                BackgroundImage["controlFillColor"] = "0 0 0 0";
                BackgroundImage["backgroundColor"] = "255 255 255 255";
                BackgroundImage["controlFontSize"] = "14";
                BackgroundImage["visible"] = "1";
                BackgroundImage["active"] = "1";
                BackgroundImage["tooltipProfile"] = "GuiToolTipProfile";
                BackgroundImage["hovertime"] = "1000";
                BackgroundImage["isContainer"] = "1";
                BackgroundImage["alphaValue"] = "1";
                BackgroundImage["mouseOverAlphaValue"] = "1";
                BackgroundImage["alphaFadeTime"] = "1000";
                BackgroundImage["moveControl"] = "0";
                BackgroundImage["lockControl"] = "0";
                BackgroundImage["windowSettings"] = "1";
                BackgroundImage["alpha"] = "1";
                BackgroundImage["mouseOverAlpha"] = "1";
                BackgroundImage["alphaFade"] = "1";
                BackgroundImage["contextFontColor"] = "0";
                BackgroundImage["contextBackColor"] = "0";
                BackgroundImage["contextFillColor"] = "0";
                BackgroundImage["contextFontSize"] = "0";
                BackgroundImage["editable"] = "0";
                BackgroundImage["canSave"] = "1";
                BackgroundImage["canSaveDynamicFields"] = "1";
                BackgroundImage["Enabled"] = "1";
                BackgroundImage["isDecoy"] = "0";
                if (true)
                {
                    #region GuiBitmapCtrl ()        LogoImage
                    LogoImage = new ObjectCreator("GuiBitmapCtrl", "");
                    LogoImage["bitmap"] = "art/gui/launcher/logo.png";
                    LogoImage["wrap"] = "0";
                    LogoImage["setBitmap"] = "0";
                    LogoImage["position"] = "-28 -2";
                    LogoImage["extent"] = "261 103";
                    LogoImage["minExtent"] = "8 2";
                    LogoImage["maxExtent"] = "1920 1080";
                    LogoImage["horizSizing"] = "right";
                    LogoImage["vertSizing"] = "bottom";
                    LogoImage["profile"] = "GuiDefaultProfile";
                    LogoImage["controlFontColor"] = "0 0 0 0";
                    LogoImage["controlFillColor"] = "0 0 0 0";
                    LogoImage["backgroundColor"] = "255 255 255 255";
                    LogoImage["controlFontSize"] = "14";
                    LogoImage["visible"] = "1";
                    LogoImage["active"] = "1";
                    LogoImage["tooltipProfile"] = "GuiToolTipProfile";
                    LogoImage["hovertime"] = "1000";
                    LogoImage["isContainer"] = "0";
                    LogoImage["alphaValue"] = "1";
                    LogoImage["mouseOverAlphaValue"] = "1";
                    LogoImage["alphaFadeTime"] = "1000";
                    LogoImage["moveControl"] = "0";
                    LogoImage["lockControl"] = "0";
                    LogoImage["windowSettings"] = "1";
                    LogoImage["alpha"] = "1";
                    LogoImage["mouseOverAlpha"] = "1";
                    LogoImage["alphaFade"] = "1";
                    LogoImage["contextFontColor"] = "0";
                    LogoImage["contextBackColor"] = "0";
                    LogoImage["contextFillColor"] = "0";
                    LogoImage["contextFontSize"] = "0";
                    LogoImage["editable"] = "0";
                    LogoImage["canSave"] = "1";
                    LogoImage["canSaveDynamicFields"] = "0";
                    LogoImage["Enabled"] = "1";
                    #endregion

                    #region GuiContainer (LauncherMenu)        MenuItemHolder
                    MenuItemHolder = new ObjectCreator("GuiContainer", "LauncherMenu");
                    MenuItemHolder["docking"] = "None";
                    MenuItemHolder["margin"] = "0 0 0 0";
                    MenuItemHolder["padding"] = "0 0 0 0";
                    MenuItemHolder["anchorTop"] = "1";
                    MenuItemHolder["anchorBottom"] = "1";
                    MenuItemHolder["anchorLeft"] = "1";
                    MenuItemHolder["anchorRight"] = "1";
                    MenuItemHolder["position"] = "20 100";
                    MenuItemHolder["extent"] = "945 616";
                    MenuItemHolder["minExtent"] = "8 2";
                    MenuItemHolder["maxExtent"] = "1920 1080";
                    MenuItemHolder["horizSizing"] = "width";
                    MenuItemHolder["vertSizing"] = "top";
                    MenuItemHolder["profile"] = "GuiDefaultProfile";
                    MenuItemHolder["controlFontColor"] = "0 0 0 0";
                    MenuItemHolder["controlFillColor"] = "0 0 0 0";
                    MenuItemHolder["backgroundColor"] = "255 255 255 255";
                    MenuItemHolder["controlFontSize"] = "14";
                    MenuItemHolder["visible"] = "1";
                    MenuItemHolder["active"] = "1";
                    MenuItemHolder["tooltipProfile"] = "GuiToolTipProfile";
                    MenuItemHolder["hovertime"] = "1000";
                    MenuItemHolder["isContainer"] = "1";
                    MenuItemHolder["alphaValue"] = "1";
                    MenuItemHolder["mouseOverAlphaValue"] = "1";
                    MenuItemHolder["alphaFadeTime"] = "1000";
                    MenuItemHolder["moveControl"] = "0";
                    MenuItemHolder["lockControl"] = "0";
                    MenuItemHolder["windowSettings"] = "1";
                    MenuItemHolder["alpha"] = "1";
                    MenuItemHolder["mouseOverAlpha"] = "1";
                    MenuItemHolder["alphaFade"] = "1";
                    MenuItemHolder["contextFontColor"] = "0";
                    MenuItemHolder["contextBackColor"] = "0";
                    MenuItemHolder["contextFillColor"] = "0";
                    MenuItemHolder["contextFontSize"] = "0";
                    MenuItemHolder["editable"] = "0";
                    MenuItemHolder["canSave"] = "1";
                    MenuItemHolder["canSaveDynamicFields"] = "0";
                    MenuItemHolder["Enabled"] = "0";

                    if (true)
                    {
                        #region GuiContainer (ContentSection)        ContentSection
                        ContentSection = new ObjectCreator("GuiContainer", "ContentSection");
                        ContentSection["docking"] = "Client";
                        ContentSection["margin"] = "0 0 0 0";
                        ContentSection["padding"] = "0 0 0 0";
                        ContentSection["anchorTop"] = "1";
                        ContentSection["anchorBottom"] = "1";
                        ContentSection["anchorLeft"] = "1";
                        ContentSection["anchorRight"] = "1";
                        ContentSection["position"] = "175 0";
                        ContentSection["extent"] = "770 616";
                        ContentSection["minExtent"] = "8 2";
                        ContentSection["maxExtent"] = "1920 1080";
                        ContentSection["horizSizing"] = "left";
                        ContentSection["vertSizing"] = "top";
                        ContentSection["profile"] = "GuiOverlayProfile";
                        ContentSection["controlFontColor"] = "0 0 0 0";
                        ContentSection["controlFillColor"] = "0 0 0 0";
                        ContentSection["backgroundColor"] = "255 255 255 255";
                        ContentSection["controlFontSize"] = "14";
                        ContentSection["visible"] = "1";
                        ContentSection["active"] = "1";
                        ContentSection["tooltipProfile"] = "GuiToolTipProfile";
                        ContentSection["hovertime"] = "1000";
                        ContentSection["isContainer"] = "1";
                        ContentSection["alphaValue"] = "1";
                        ContentSection["mouseOverAlphaValue"] = "1";
                        ContentSection["alphaFadeTime"] = "1000";
                        ContentSection["moveControl"] = "0";
                        ContentSection["lockControl"] = "0";
                        ContentSection["windowSettings"] = "1";
                        ContentSection["alpha"] = "1";
                        ContentSection["mouseOverAlpha"] = "1";
                        ContentSection["alphaFade"] = "1";
                        ContentSection["contextFontColor"] = "0";
                        ContentSection["contextBackColor"] = "0";
                        ContentSection["contextFillColor"] = "0";
                        ContentSection["contextFontSize"] = "0";
                        ContentSection["editable"] = "0";
                        ContentSection["canSave"] = "1";
                        ContentSection["canSaveDynamicFields"] = "0";
                        ContentSection["Enabled"] = "0";
                        if (true)
                        {
                            #region GuiBitmapCtrl ()        ContentPanelLeft
                            ContentPanelLeft = new ObjectCreator("GuiBitmapCtrl", "");
                            ContentPanelLeft["bitmap"] = "art/gui/launcher/contentpanelbgleft.png";
                            ContentPanelLeft["wrap"] = "0";
                            ContentPanelLeft["setBitmap"] = "0";
                            ContentPanelLeft["position"] = "0 0";
                            ContentPanelLeft["extent"] = "163 616";
                            ContentPanelLeft["minExtent"] = "8 2";
                            ContentPanelLeft["maxExtent"] = "1920 1080";
                            ContentPanelLeft["horizSizing"] = "right";
                            ContentPanelLeft["vertSizing"] = "bottom";
                            ContentPanelLeft["profile"] = "GuiDefaultProfile";
                            ContentPanelLeft["controlFontColor"] = "0 0 0 0";
                            ContentPanelLeft["controlFillColor"] = "0 0 0 0";
                            ContentPanelLeft["backgroundColor"] = "255 255 255 255";
                            ContentPanelLeft["controlFontSize"] = "14";
                            ContentPanelLeft["visible"] = "1";
                            ContentPanelLeft["active"] = "1";
                            ContentPanelLeft["tooltipProfile"] = "GuiToolTipProfile";
                            ContentPanelLeft["hovertime"] = "1000";
                            ContentPanelLeft["isContainer"] = "0";
                            ContentPanelLeft["alphaValue"] = "1";
                            ContentPanelLeft["mouseOverAlphaValue"] = "1";
                            ContentPanelLeft["alphaFadeTime"] = "1000";
                            ContentPanelLeft["moveControl"] = "0";
                            ContentPanelLeft["lockControl"] = "0";
                            ContentPanelLeft["windowSettings"] = "1";
                            ContentPanelLeft["alpha"] = "1";
                            ContentPanelLeft["mouseOverAlpha"] = "1";
                            ContentPanelLeft["alphaFade"] = "1";
                            ContentPanelLeft["contextFontColor"] = "0";
                            ContentPanelLeft["contextBackColor"] = "0";
                            ContentPanelLeft["contextFillColor"] = "0";
                            ContentPanelLeft["contextFontSize"] = "0";
                            ContentPanelLeft["editable"] = "0";
                            ContentPanelLeft["canSave"] = "1";
                            ContentPanelLeft["canSaveDynamicFields"] = "0";
                            ContentPanelLeft["Enabled"] = "0";
                            #endregion

                            ContentSection["#ContentPanelLeft"] = ContentPanelLeft;

                            #region GuiBitmapCtrl ()        ContentPanelLBg
                            ContentPanelBg = new ObjectCreator("GuiBitmapCtrl", "");
                            ContentPanelBg["bitmap"] = "art/gui/launcher/contentpanelbg.png";
                            ContentPanelBg["wrap"] = "0";
                            ContentPanelBg["setBitmap"] = "0";
                            ContentPanelBg["position"] = "163 0";
                            ContentPanelBg["extent"] = "465 616";
                            ContentPanelBg["minExtent"] = "8 2";
                            ContentPanelBg["maxExtent"] = "1920 1080";
                            ContentPanelBg["horizSizing"] = "width";
                            ContentPanelBg["vertSizing"] = "bottom";
                            ContentPanelBg["profile"] = "GuiDefaultProfile";
                            ContentPanelBg["controlFontColor"] = "0 0 0 0";
                            ContentPanelBg["controlFillColor"] = "0 0 0 0";
                            ContentPanelBg["backgroundColor"] = "255 255 255 255";
                            ContentPanelBg["controlFontSize"] = "14";
                            ContentPanelBg["visible"] = "1";
                            ContentPanelBg["active"] = "1";
                            ContentPanelBg["tooltipProfile"] = "GuiToolTipProfile";
                            ContentPanelBg["hovertime"] = "1000";
                            ContentPanelBg["isContainer"] = "0";
                            ContentPanelBg["alphaValue"] = "1";
                            ContentPanelBg["mouseOverAlphaValue"] = "1";
                            ContentPanelBg["alphaFadeTime"] = "1000";
                            ContentPanelBg["moveControl"] = "0";
                            ContentPanelBg["lockControl"] = "0";
                            ContentPanelBg["windowSettings"] = "1";
                            ContentPanelBg["alpha"] = "1";
                            ContentPanelBg["mouseOverAlpha"] = "1";
                            ContentPanelBg["alphaFade"] = "1";
                            ContentPanelBg["contextFontColor"] = "0";
                            ContentPanelBg["contextBackColor"] = "0";
                            ContentPanelBg["contextFillColor"] = "0";
                            ContentPanelBg["contextFontSize"] = "0";
                            ContentPanelBg["editable"] = "0";
                            ContentPanelBg["canSave"] = "1";
                            ContentPanelBg["canSaveDynamicFields"] = "0";
                            ContentPanelBg["Enabled"] = "1";
                            #endregion

                            ContentSection["#ContentPanelBg"] = ContentPanelBg;

                            #region GuiBitmapCtrl ()        ContentPanelRight
                            ContentPanelRight = new ObjectCreator("GuiBitmapCtrl", "");
                            ContentPanelRight["bitmap"] = "art/gui/launcher/contentpanelbgright.png";
                            ContentPanelRight["wrap"] = "0";
                            ContentPanelRight["setBitmap"] = "0";
                            ContentPanelRight["position"] = "628 0";
                            ContentPanelRight["extent"] = "142 616";
                            ContentPanelRight["minExtent"] = "8 2";
                            ContentPanelRight["maxExtent"] = "1920 1080";
                            ContentPanelRight["horizSizing"] = "left";
                            ContentPanelRight["vertSizing"] = "bottom";
                            ContentPanelRight["profile"] = "GuiDefaultProfile";
                            ContentPanelRight["controlFontColor"] = "0 0 0 0";
                            ContentPanelRight["controlFillColor"] = "0 0 0 0";
                            ContentPanelRight["backgroundColor"] = "255 255 255 255";
                            ContentPanelRight["controlFontSize"] = "14";
                            ContentPanelRight["visible"] = "1";
                            ContentPanelRight["active"] = "1";
                            ContentPanelRight["tooltipProfile"] = "GuiToolTipProfile";
                            ContentPanelRight["hovertime"] = "1000";
                            ContentPanelRight["isContainer"] = "0";
                            ContentPanelRight["alphaValue"] = "1";
                            ContentPanelRight["mouseOverAlphaValue"] = "1";
                            ContentPanelRight["alphaFadeTime"] = "1000";
                            ContentPanelRight["moveControl"] = "0";
                            ContentPanelRight["lockControl"] = "0";
                            ContentPanelRight["windowSettings"] = "1";
                            ContentPanelRight["alpha"] = "1";
                            ContentPanelRight["mouseOverAlpha"] = "1";
                            ContentPanelRight["alphaFade"] = "1";
                            ContentPanelRight["contextFontColor"] = "0";
                            ContentPanelRight["contextBackColor"] = "0";
                            ContentPanelRight["contextFillColor"] = "0";
                            ContentPanelRight["contextFontSize"] = "0";
                            ContentPanelRight["editable"] = "0";
                            ContentPanelRight["canSave"] = "1";
                            ContentPanelRight["canSaveDynamicFields"] = "0";
                            ContentPanelRight["Enabled"] = "1";
                            #endregion

                            ContentSection["#ContentPanelRight"] = ContentPanelRight;

                            #region GuiTextCtrl ()        ContentTitle
                            ContentTitle = new ObjectCreator("GuiTextCtrl", "ContentSectionTitle");
                            ContentTitle["text"] = "Developer Panel";
                            ContentTitle["maxLength"] = "1024";
                            ContentTitle["margin"] = "0 0 0 0";
                            ContentTitle["padding"] = "0 0 0 0";
                            ContentTitle["anchorTop"] = "1";
                            ContentTitle["anchorBottom"] = "0";
                            ContentTitle["anchorLeft"] = "1";
                            ContentTitle["anchorRight"] = "0";
                            ContentTitle["position"] = "107 24";
                            ContentTitle["extent"] = "559 43";
                            ContentTitle["minExtent"] = "8 2";
                            ContentTitle["maxExtent"] = "1920 1080";
                            ContentTitle["horizSizing"] = "width";
                            ContentTitle["vertSizing"] = "bottom";
                            ContentTitle["profile"] = "ToolsGuiTextBoldCenterProfile";
                            ContentTitle["controlFontColor"] = "0 0 0 0";
                            ContentTitle["controlFillColor"] = "0 0 0 0";
                            ContentTitle["backgroundColor"] = "255 255 255 255";
                            ContentTitle["controlFontSize"] = "48";
                            ContentTitle["visible"] = "1";
                            ContentTitle["active"] = "1";
                            ContentTitle["tooltipProfile"] = "GuiToolTipProfile";
                            ContentTitle["hovertime"] = "1000";
                            ContentTitle["isContainer"] = "1";
                            ContentTitle["alphaValue"] = "1";
                            ContentTitle["mouseOverAlphaValue"] = "1";
                            ContentTitle["alphaFadeTime"] = "1000";
                            ContentTitle["moveControl"] = "0";
                            ContentTitle["lockControl"] = "0";
                            ContentTitle["windowSettings"] = "1";
                            ContentTitle["alpha"] = "1";
                            ContentTitle["mouseOverAlpha"] = "1";
                            ContentTitle["alphaFade"] = "1";
                            ContentTitle["contextFontColor"] = "0";
                            ContentTitle["contextBackColor"] = "0";
                            ContentTitle["contextFillColor"] = "0";
                            ContentTitle["contextFontSize"] = "0";
                            ContentTitle["locked"] = "1";
                            ContentTitle["editable"] = "0";
                            ContentTitle["canSave"] = "1";
                            ContentTitle["canSaveDynamicFields"] = "0";
                            ContentTitle["Enabled"] = "1";
                            #endregion

                            ContentSection["#ContentTitle"] = ContentTitle;

                            #region GuiContainer (OptionsTab)        OptionsTab
                            OptionsTab = new ObjectCreator("GuiContainer", "OptionsTab");
                            OptionsTab["docking"] = "Client";
                            OptionsTab["margin"] = "0 0 0 0";
                            OptionsTab["padding"] = "0 0 0 0";
                            OptionsTab["anchorTop"] = "1";
                            OptionsTab["anchorBottom"] = "0";
                            OptionsTab["anchorLeft"] = "1";
                            OptionsTab["anchorRight"] = "0";
                            OptionsTab["position"] = "0 0";
                            OptionsTab["extent"] = "1186 616";
                            OptionsTab["minExtent"] = "8 2";
                            OptionsTab["maxExtent"] = "1920 1080";
                            OptionsTab["horizSizing"] = "left";
                            OptionsTab["vertSizing"] = "top";
                            OptionsTab["profile"] = "GuiDefaultProfile";
                            OptionsTab["controlFontColor"] = "0 0 0 0";
                            OptionsTab["controlFillColor"] = "0 0 0 0";
                            OptionsTab["backgroundColor"] = "255 255 255 255";
                            OptionsTab["controlFontSize"] = "14";
                            OptionsTab["visible"] = "0";
                            OptionsTab["active"] = "1";
                            OptionsTab["tooltipProfile"] = "GuiToolTipProfile";
                            OptionsTab["hovertime"] = "1000";
                            OptionsTab["isContainer"] = "1";
                            OptionsTab["alphaValue"] = "1";
                            OptionsTab["mouseOverAlphaValue"] = "1";
                            OptionsTab["alphaFadeTime"] = "1000";
                            OptionsTab["moveControl"] = "0";
                            OptionsTab["lockControl"] = "0";
                            OptionsTab["windowSettings"] = "1";
                            OptionsTab["alpha"] = "1";
                            OptionsTab["mouseOverAlpha"] = "1";
                            OptionsTab["alphaFade"] = "1";
                            OptionsTab["contextFontColor"] = "0";
                            OptionsTab["contextBackColor"] = "0";
                            OptionsTab["contextFillColor"] = "0";
                            OptionsTab["contextFontSize"] = "0";
                            OptionsTab["hidden"] = "1";
                            OptionsTab["editable"] = "0";
                            OptionsTab["canSave"] = "1";
                            OptionsTab["canSaveDynamicFields"] = "0";
                            OptionsTab["Enabled"] = "1";
                            if (true)
                            {
                                #region GuiContainer ()        OptionsBody
                                OptionsBody = new ObjectCreator("GuiContainer", "");
                                OptionsBody["margin"] = "0 0 0 0";
                                OptionsBody["padding"] = "0 0 0 0";
                                OptionsBody["anchorTop"] = "1";
                                OptionsBody["anchorBottom"] = "0";
                                OptionsBody["anchorLeft"] = "1";
                                OptionsBody["anchorRight"] = "0";
                                OptionsBody["position"] = "40 166";
                                OptionsBody["extent"] = "687 423";
                                OptionsBody["minExtent"] = "8 2";
                                OptionsBody["maxExtent"] = "1920 1080";
                                OptionsBody["horizSizing"] = "right";
                                OptionsBody["vertSizing"] = "bottom";
                                OptionsBody["profile"] = "GuiDefaultProfile";
                                OptionsBody["controlFontColor"] = "0 0 0 0";
                                OptionsBody["controlFillColor"] = "0 0 0 0";
                                OptionsBody["backgroundColor"] = "255 255 255 255";
                                OptionsBody["controlFontSize"] = "-1";
                                OptionsBody["visible"] = "1";
                                OptionsBody["active"] = "1";
                                OptionsBody["tooltipProfile"] = "GuiToolTipProfile";
                                OptionsBody["hovertime"] = "1000";
                                OptionsBody["isContainer"] = "1";
                                OptionsBody["alphaValue"] = "1";
                                OptionsBody["mouseOverAlphaValue"] = "1";
                                OptionsBody["alphaFadeTime"] = "1000";
                                OptionsBody["moveControl"] = "0";
                                OptionsBody["lockControl"] = "0";
                                OptionsBody["windowSettings"] = "1";
                                OptionsBody["alpha"] = "1";
                                OptionsBody["mouseOverAlpha"] = "1";
                                OptionsBody["alphaFade"] = "1";
                                OptionsBody["contextFontColor"] = "0";
                                OptionsBody["contextBackColor"] = "0";
                                OptionsBody["contextFillColor"] = "0";
                                OptionsBody["contextFontSize"] = "0";
                                OptionsBody["editable"] = "0";
                                OptionsBody["canSave"] = "1";
                                OptionsBody["canSaveDynamicFields"] = "0";
                                OptionsBody["Enabled"] = "0";
                                if (true)
                                {

                                    #region GuiMLTextCtrl ()        OptionsBodyText
                                    OptionsBodyText = new ObjectCreator("GuiMLTextCtrl", "");
                                    OptionsBodyText["lineSpacing"] = "2";
                                    OptionsBodyText["allowColorChars"] = "0";
                                    OptionsBodyText["maxChars"] = "-1";
                                    OptionsBodyText["text"] = "Options should have popped up, reselect tab if not.";
                                    OptionsBodyText["useURLMouseCursor"] = "0";
                                    OptionsBodyText["position"] = "20 26";
                                    OptionsBodyText["extent"] = "326 14";
                                    OptionsBodyText["minExtent"] = "8 2";
                                    OptionsBodyText["maxExtent"] = "1920 1080";
                                    OptionsBodyText["horizSizing"] = "width";
                                    OptionsBodyText["vertSizing"] = "bottom";
                                    OptionsBodyText["profile"] = "GuiMLTextProfile";
                                    OptionsBodyText["controlFontColor"] = "0 0 0 0";
                                    OptionsBodyText["controlFillColor"] = "0 0 0 0";
                                    OptionsBodyText["backgroundColor"] = "255 255 255 255";
                                    OptionsBodyText["controlFontSize"] = "-1";
                                    OptionsBodyText["visible"] = "1";
                                    OptionsBodyText["active"] = "1";
                                    OptionsBodyText["tooltipProfile"] = "GuiToolTipProfile";
                                    OptionsBodyText["hovertime"] = "1000";
                                    OptionsBodyText["isContainer"] = "0";
                                    OptionsBodyText["alphaValue"] = "1";
                                    OptionsBodyText["mouseOverAlphaValue"] = "1";
                                    OptionsBodyText["alphaFadeTime"] = "1000";
                                    OptionsBodyText["windowSettings"] = "1";
                                    OptionsBodyText["alpha"] = "1";
                                    OptionsBodyText["mouseOverAlpha"] = "1";
                                    OptionsBodyText["alphaFade"] = "1";
                                    OptionsBodyText["contextFontColor"] = "0";
                                    OptionsBodyText["contextBackColor"] = "0";
                                    OptionsBodyText["contextFillColor"] = "0";
                                    OptionsBodyText["contextFontSize"] = "0";
                                    OptionsBodyText["editable"] = "0";
                                    OptionsBodyText["canSave"] = "1";
                                    OptionsBodyText["canSaveDynamicFields"] = "0";
                                    OptionsBodyText["Enabled"] = "0";
                                    #endregion

                                    OptionsBody["#OptionsBodyText"] = OptionsBodyText;

                                }
                                #endregion

                                OptionsTab["#OptionsBody"] = OptionsBody;
                            }
                            #endregion
                            #region GuiContainer (DevTab)        DevTab
                            DevTab = new ObjectCreator("GuiContainer", "DevTab");
                            DevTab["docking"] = "Client";
                            DevTab["margin"] = "0 0 0 0";
                            DevTab["padding"] = "0 0 0 0";
                            DevTab["anchorTop"] = "1";
                            DevTab["anchorBottom"] = "0";
                            DevTab["anchorLeft"] = "1";
                            DevTab["anchorRight"] = "0";
                            DevTab["position"] = "0 0";
                            DevTab["extent"] = "1186 616";
                            DevTab["minExtent"] = "8 2";
                            DevTab["maxExtent"] = "1920 1080";
                            DevTab["horizSizing"] = "left";
                            DevTab["vertSizing"] = "top";
                            DevTab["profile"] = "GuiDefaultProfile";
                            DevTab["controlFontColor"] = "0 0 0 0";
                            DevTab["controlFillColor"] = "0 0 0 0";
                            DevTab["backgroundColor"] = "255 255 255 255";
                            DevTab["controlFontSize"] = "14";
                            DevTab["visible"] = "1";
                            DevTab["active"] = "1";
                            DevTab["tooltipProfile"] = "GuiToolTipProfile";
                            DevTab["hovertime"] = "1000";
                            DevTab["isContainer"] = "1";
                            DevTab["alphaValue"] = "1";
                            DevTab["mouseOverAlphaValue"] = "1";
                            DevTab["alphaFadeTime"] = "1000";
                            DevTab["moveControl"] = "0";
                            DevTab["lockControl"] = "0";
                            DevTab["windowSettings"] = "1";
                            DevTab["alpha"] = "1";
                            DevTab["mouseOverAlpha"] = "1";
                            DevTab["alphaFade"] = "1";
                            DevTab["contextFontColor"] = "0";
                            DevTab["contextBackColor"] = "0";
                            DevTab["contextFillColor"] = "0";
                            DevTab["contextFontSize"] = "0";
                            DevTab["hidden"] = "1";
                            DevTab["editable"] = "0";
                            DevTab["canSave"] = "1";
                            DevTab["canSaveDynamicFields"] = "0";
                            DevTab["Enabled"] = "1";
                            if (true)
                            {
                                #region GuiContainer ()        DevBody
                                DevBody = new ObjectCreator("GuiContainer", "");
                                DevBody["margin"] = "0 0 0 0";
                                DevBody["padding"] = "0 0 0 0";
                                DevBody["anchorTop"] = "1";
                                DevBody["anchorBottom"] = "0";
                                DevBody["anchorLeft"] = "1";
                                DevBody["anchorRight"] = "0";
                                DevBody["position"] = "40 166";
                                DevBody["extent"] = "687 423";
                                DevBody["minExtent"] = "8 2";
                                DevBody["maxExtent"] = "1920 1080";
                                DevBody["horizSizing"] = "right";
                                DevBody["vertSizing"] = "bottom";
                                DevBody["profile"] = "GuiDefaultProfile";
                                DevBody["controlFontColor"] = "0 0 0 0";
                                DevBody["controlFillColor"] = "0 0 0 0";
                                DevBody["backgroundColor"] = "255 255 255 255";
                                DevBody["controlFontSize"] = "-1";
                                DevBody["visible"] = "1";
                                DevBody["active"] = "1";
                                DevBody["tooltipProfile"] = "GuiToolTipProfile";
                                DevBody["hovertime"] = "1000";
                                DevBody["isContainer"] = "1";
                                DevBody["alphaValue"] = "1";
                                DevBody["mouseOverAlphaValue"] = "1";
                                DevBody["alphaFadeTime"] = "1000";
                                DevBody["moveControl"] = "0";
                                DevBody["lockControl"] = "0";
                                DevBody["windowSettings"] = "1";
                                DevBody["alpha"] = "1";
                                DevBody["mouseOverAlpha"] = "1";
                                DevBody["alphaFade"] = "1";
                                DevBody["contextFontColor"] = "0";
                                DevBody["contextBackColor"] = "0";
                                DevBody["contextFillColor"] = "0";
                                DevBody["contextFontSize"] = "0";
                                DevBody["editable"] = "0";
                                DevBody["canSave"] = "1";
                                DevBody["canSaveDynamicFields"] = "0";
                                DevBody["Enabled"] = "0";
                                if (true)
                                {

                                    #region GuiButtonCtrl ()        GuiEditorButton
                                    GuiEditorButton = new ObjectCreator("GuiButtonCtrl", "");
                                    GuiEditorButton["text"] = "Gui Editor";
                                    GuiEditorButton["groupNum"] = "-1";
                                    GuiEditorButton["buttonType"] = "PushButton";
                                    GuiEditorButton["useMouseEvents"] = "0";
                                    GuiEditorButton["position"] = "46 274";
                                    GuiEditorButton["extent"] = "202 75";
                                    GuiEditorButton["minExtent"] = "8 8";
                                    GuiEditorButton["maxExtent"] = "1920 1080";
                                    GuiEditorButton["horizSizing"] = "relative";
                                    GuiEditorButton["vertSizing"] = "bottom";
                                    GuiEditorButton["profile"] = "GuiMenuButtonProfile";
                                    GuiEditorButton["controlFontColor"] = "0 0 0 0";
                                    GuiEditorButton["backgroundColor"] = "255 255 255 255";
                                    GuiEditorButton["controlFontSize"] = "18";
                                    GuiEditorButton["visible"] = "1";
                                    GuiEditorButton["active"] = "1";
                                    GuiEditorButton["command"] = "GuiEdit();";
                                    GuiEditorButton["tooltipProfile"] = "GuiToolTipProfile";
                                    GuiEditorButton["tooltip"] = "The GUI Editor is accessible in-game by pressing F10";
                                    GuiEditorButton["hovertime"] = "1000";
                                    GuiEditorButton["isContainer"] = "0";
                                    GuiEditorButton["alphaValue"] = "1";
                                    GuiEditorButton["mouseOverAlphaValue"] = "1";
                                    GuiEditorButton["alphaFadeTime"] = "1000";
                                    GuiEditorButton["windowSettings"] = "1";
                                    GuiEditorButton["alpha"] = "1";
                                    GuiEditorButton["mouseOverAlpha"] = "1";
                                    GuiEditorButton["alphaFade"] = "1";
                                    GuiEditorButton["contextFontColor"] = "0";
                                    GuiEditorButton["contextBackColor"] = "0";
                                    GuiEditorButton["contextFontSize"] = "0";
                                    GuiEditorButton["internalName"] = "GuiEditorButton";
                                    GuiEditorButton["editable"] = "0";
                                    GuiEditorButton["canSave"] = "1";
                                    GuiEditorButton["canSaveDynamicFields"] = "0";
                                    GuiEditorButton["Enabled"] = "1";
                                    #endregion

                                    DevBody["#GuiEditorButton"] = GuiEditorButton;

                                    #region GuiButtonCtrl ()        WorldEditorButton
                                    WorldEditorButton = new ObjectCreator("GuiButtonCtrl", "");
                                    WorldEditorButton["text"] = "World Editor";
                                    WorldEditorButton["groupNum"] = "-1";
                                    WorldEditorButton["buttonType"] = "PushButton";
                                    WorldEditorButton["useMouseEvents"] = "0";
                                    WorldEditorButton["position"] = "46 335";
                                    WorldEditorButton["extent"] = "202 75";
                                    WorldEditorButton["minExtent"] = "8 8";
                                    WorldEditorButton["maxExtent"] = "1920 1080";
                                    WorldEditorButton["horizSizing"] = "relative";
                                    WorldEditorButton["vertSizing"] = "bottom";
                                    WorldEditorButton["profile"] = "GuiMenuButtonProfile";
                                    WorldEditorButton["controlFontColor"] = "0 0 0 0";
                                    WorldEditorButton["backgroundColor"] = "255 255 255 255";
                                    WorldEditorButton["controlFontSize"] = "18";
                                    WorldEditorButton["visible"] = "1";
                                    WorldEditorButton["active"] = "1";
                                    WorldEditorButton["command"] = "toggleEditor(1);";
                                    WorldEditorButton["tooltipProfile"] = "GuiToolTipProfile";
                                    WorldEditorButton["tooltip"] = "The World Editor is accessible in-game by pressing F11";
                                    WorldEditorButton["hovertime"] = "1000";
                                    WorldEditorButton["isContainer"] = "0";
                                    WorldEditorButton["alphaValue"] = "1";
                                    WorldEditorButton["mouseOverAlphaValue"] = "1";
                                    WorldEditorButton["alphaFadeTime"] = "1000";
                                    WorldEditorButton["windowSettings"] = "1";
                                    WorldEditorButton["alpha"] = "1";
                                    WorldEditorButton["mouseOverAlpha"] = "1";
                                    WorldEditorButton["alphaFade"] = "1";
                                    WorldEditorButton["contextFontColor"] = "0";
                                    WorldEditorButton["contextBackColor"] = "0";
                                    WorldEditorButton["contextFontSize"] = "0";
                                    WorldEditorButton["internalName"] = "WorldEditorButton";
                                    WorldEditorButton["editable"] = "0";
                                    WorldEditorButton["canSave"] = "1";
                                    WorldEditorButton["canSaveDynamicFields"] = "0";
                                    WorldEditorButton["Enabled"] = "1";
                                    #endregion

                                    DevBody["#WorldEditorButton"] = WorldEditorButton;

                                    #region GuiMLTextCtrl ()        DevBodyText
                                    DevBodyText = new ObjectCreator("GuiMLTextCtrl", "");
                                    DevBodyText["lineSpacing"] = "2";
                                    DevBodyText["allowColorChars"] = "0";
                                    DevBodyText["maxChars"] = "-1";
                                    DevBodyText["text"] = "This is the developer control panel.<br>The current Dev are available below.<br>Do not try to change what\'s here, tell Erin before you break this.";
                                    DevBodyText["useURLMouseCursor"] = "0";
                                    DevBodyText["position"] = "20 26";
                                    DevBodyText["extent"] = "326 14";
                                    DevBodyText["minExtent"] = "8 2";
                                    DevBodyText["maxExtent"] = "1920 1080";
                                    DevBodyText["horizSizing"] = "width";
                                    DevBodyText["vertSizing"] = "bottom";
                                    DevBodyText["profile"] = "GuiMLTextProfile";
                                    DevBodyText["controlFontColor"] = "0 0 0 0";
                                    DevBodyText["controlFillColor"] = "0 0 0 0";
                                    DevBodyText["backgroundColor"] = "255 255 255 255";
                                    DevBodyText["controlFontSize"] = "-1";
                                    DevBodyText["visible"] = "1";
                                    DevBodyText["active"] = "1";
                                    DevBodyText["tooltipProfile"] = "GuiToolTipProfile";
                                    DevBodyText["hovertime"] = "1000";
                                    DevBodyText["isContainer"] = "0";
                                    DevBodyText["alphaValue"] = "1";
                                    DevBodyText["mouseOverAlphaValue"] = "1";
                                    DevBodyText["alphaFadeTime"] = "1000";
                                    DevBodyText["windowSettings"] = "1";
                                    DevBodyText["alpha"] = "1";
                                    DevBodyText["mouseOverAlpha"] = "1";
                                    DevBodyText["alphaFade"] = "1";
                                    DevBodyText["contextFontColor"] = "0";
                                    DevBodyText["contextBackColor"] = "0";
                                    DevBodyText["contextFillColor"] = "0";
                                    DevBodyText["contextFontSize"] = "0";
                                    DevBodyText["editable"] = "0";
                                    DevBodyText["canSave"] = "1";
                                    DevBodyText["canSaveDynamicFields"] = "0";
                                    DevBodyText["Enabled"] = "0";
                                    #endregion

                                    DevBody["#DevBodyText"] = DevBodyText;

                                }
                                #endregion

                                DevTab["#DevBody"] = DevBody;
                            }
                            #endregion
                            #region GuiContainer (ServerTab)        ServerTab
                            ServerTab = new ObjectCreator("GuiContainer", "ServerTab");
                            ServerTab["docking"] = "Client";
                            ServerTab["margin"] = "0 0 0 0";
                            ServerTab["padding"] = "0 0 0 0";
                            ServerTab["anchorTop"] = "1";
                            ServerTab["anchorBottom"] = "0";
                            ServerTab["anchorLeft"] = "1";
                            ServerTab["anchorRight"] = "0";
                            ServerTab["position"] = "0 0";
                            ServerTab["extent"] = "1186 616";
                            ServerTab["minExtent"] = "8 2";
                            ServerTab["maxExtent"] = "1920 1080";
                            ServerTab["horizSizing"] = "left";
                            ServerTab["vertSizing"] = "top";
                            ServerTab["profile"] = "GuiDefaultProfile";
                            ServerTab["controlFontColor"] = "0 0 0 0";
                            ServerTab["controlFillColor"] = "0 0 0 0";
                            ServerTab["backgroundColor"] = "255 255 255 255";
                            ServerTab["controlFontSize"] = "14";
                            ServerTab["visible"] = "0";
                            ServerTab["active"] = "1";
                            ServerTab["tooltipProfile"] = "GuiToolTipProfile";
                            ServerTab["hovertime"] = "1000";
                            ServerTab["isContainer"] = "1";
                            ServerTab["alphaValue"] = "1";
                            ServerTab["mouseOverAlphaValue"] = "1";
                            ServerTab["alphaFadeTime"] = "1000";
                            ServerTab["moveControl"] = "0";
                            ServerTab["lockControl"] = "0";
                            ServerTab["windowSettings"] = "1";
                            ServerTab["alpha"] = "1";
                            ServerTab["mouseOverAlpha"] = "1";
                            ServerTab["alphaFade"] = "1";
                            ServerTab["contextFontColor"] = "0";
                            ServerTab["contextBackColor"] = "0";
                            ServerTab["contextFillColor"] = "0";
                            ServerTab["contextFontSize"] = "0";
                            ServerTab["hidden"] = "1";
                            ServerTab["editable"] = "0";
                            ServerTab["canSave"] = "1";
                            ServerTab["canSaveDynamicFields"] = "0";
                            ServerTab["Enabled"] = "1";
                            if (true)
                            {
                                #region GuiContainer ()        ServerBody
                                ServerBody = new ObjectCreator("GuiContainer", "");
                                ServerBody["margin"] = "0 0 0 0";
                                ServerBody["padding"] = "0 0 0 0";
                                ServerBody["anchorTop"] = "1";
                                ServerBody["anchorBottom"] = "0";
                                ServerBody["anchorLeft"] = "1";
                                ServerBody["anchorRight"] = "0";
                                ServerBody["position"] = "40 166";
                                ServerBody["extent"] = "687 423";
                                ServerBody["minExtent"] = "8 2";
                                ServerBody["maxExtent"] = "1920 1080";
                                ServerBody["horizSizing"] = "right";
                                ServerBody["vertSizing"] = "bottom";
                                ServerBody["profile"] = "GuiDefaultProfile";
                                ServerBody["controlFontColor"] = "0 0 0 0";
                                ServerBody["controlFillColor"] = "0 0 0 0";
                                ServerBody["backgroundColor"] = "255 255 255 255";
                                ServerBody["controlFontSize"] = "-1";
                                ServerBody["visible"] = "1";
                                ServerBody["active"] = "1";
                                ServerBody["tooltipProfile"] = "GuiToolTipProfile";
                                ServerBody["hovertime"] = "1000";
                                ServerBody["isContainer"] = "1";
                                ServerBody["alphaValue"] = "1";
                                ServerBody["mouseOverAlphaValue"] = "1";
                                ServerBody["alphaFadeTime"] = "1000";
                                ServerBody["moveControl"] = "0";
                                ServerBody["lockControl"] = "0";
                                ServerBody["windowSettings"] = "1";
                                ServerBody["alpha"] = "1";
                                ServerBody["mouseOverAlpha"] = "1";
                                ServerBody["alphaFade"] = "1";
                                ServerBody["contextFontColor"] = "0";
                                ServerBody["contextBackColor"] = "0";
                                ServerBody["contextFillColor"] = "0";
                                ServerBody["contextFontSize"] = "0";
                                ServerBody["editable"] = "0";
                                ServerBody["canSave"] = "1";
                                ServerBody["canSaveDynamicFields"] = "0";
                                ServerBody["Enabled"] = "0";
                                if (true)
                                {

                                    #region GuiMLTextCtrl ()        ServerBodyText
                                    ServerBodyText = new ObjectCreator("GuiMLTextCtrl", "");
                                    ServerBodyText["lineSpacing"] = "2";
                                    ServerBodyText["allowColorChars"] = "0";
                                    ServerBodyText["maxChars"] = "-1";
                                    ServerBodyText["text"] = "No server information yet. Add mockup later.";
                                    ServerBodyText["useURLMouseCursor"] = "0";
                                    ServerBodyText["position"] = "20 26";
                                    ServerBodyText["extent"] = "326 14";
                                    ServerBodyText["minExtent"] = "8 2";
                                    ServerBodyText["maxExtent"] = "1920 1080";
                                    ServerBodyText["horizSizing"] = "width";
                                    ServerBodyText["vertSizing"] = "bottom";
                                    ServerBodyText["profile"] = "GuiMLTextProfile";
                                    ServerBodyText["controlFontColor"] = "0 0 0 0";
                                    ServerBodyText["controlFillColor"] = "0 0 0 0";
                                    ServerBodyText["backgroundColor"] = "255 255 255 255";
                                    ServerBodyText["controlFontSize"] = "-1";
                                    ServerBodyText["visible"] = "1";
                                    ServerBodyText["active"] = "1";
                                    ServerBodyText["tooltipProfile"] = "GuiToolTipProfile";
                                    ServerBodyText["hovertime"] = "1000";
                                    ServerBodyText["isContainer"] = "0";
                                    ServerBodyText["alphaValue"] = "1";
                                    ServerBodyText["mouseOverAlphaValue"] = "1";
                                    ServerBodyText["alphaFadeTime"] = "1000";
                                    ServerBodyText["windowSettings"] = "1";
                                    ServerBodyText["alpha"] = "1";
                                    ServerBodyText["mouseOverAlpha"] = "1";
                                    ServerBodyText["alphaFade"] = "1";
                                    ServerBodyText["contextFontColor"] = "0";
                                    ServerBodyText["contextBackColor"] = "0";
                                    ServerBodyText["contextFillColor"] = "0";
                                    ServerBodyText["contextFontSize"] = "0";
                                    ServerBodyText["editable"] = "0";
                                    ServerBodyText["canSave"] = "1";
                                    ServerBodyText["canSaveDynamicFields"] = "0";
                                    ServerBodyText["Enabled"] = "0";
                                    #endregion

                                    ServerBody["#ServerBodyText"] = ServerBodyText;

                                }
                                #endregion

                                ServerTab["#ServerBody"] = ServerBody;
                            }
                            #endregion
                            #region GuiContainer (CommunityTab)        CommunityTab
                            CommunityTab = new ObjectCreator("GuiContainer", "CommunityTab");
                            CommunityTab["docking"] = "Client";
                            CommunityTab["margin"] = "0 0 0 0";
                            CommunityTab["padding"] = "0 0 0 0";
                            CommunityTab["anchorTop"] = "1";
                            CommunityTab["anchorBottom"] = "0";
                            CommunityTab["anchorLeft"] = "1";
                            CommunityTab["anchorRight"] = "0";
                            CommunityTab["position"] = "0 0";
                            CommunityTab["extent"] = "1186 616";
                            CommunityTab["minExtent"] = "8 2";
                            CommunityTab["maxExtent"] = "1920 1080";
                            CommunityTab["horizSizing"] = "left";
                            CommunityTab["vertSizing"] = "top";
                            CommunityTab["profile"] = "GuiDefaultProfile";
                            CommunityTab["controlFontColor"] = "0 0 0 0";
                            CommunityTab["controlFillColor"] = "0 0 0 0";
                            CommunityTab["backgroundColor"] = "255 255 255 255";
                            CommunityTab["controlFontSize"] = "14";
                            CommunityTab["visible"] = "0";
                            CommunityTab["active"] = "1";
                            CommunityTab["tooltipProfile"] = "GuiToolTipProfile";
                            CommunityTab["hovertime"] = "1000";
                            CommunityTab["isContainer"] = "1";
                            CommunityTab["alphaValue"] = "1";
                            CommunityTab["mouseOverAlphaValue"] = "1";
                            CommunityTab["alphaFadeTime"] = "1000";
                            CommunityTab["moveControl"] = "0";
                            CommunityTab["lockControl"] = "0";
                            CommunityTab["windowSettings"] = "1";
                            CommunityTab["alpha"] = "1";
                            CommunityTab["mouseOverAlpha"] = "1";
                            CommunityTab["alphaFade"] = "1";
                            CommunityTab["contextFontColor"] = "0";
                            CommunityTab["contextBackColor"] = "0";
                            CommunityTab["contextFillColor"] = "0";
                            CommunityTab["contextFontSize"] = "0";
                            CommunityTab["hidden"] = "1";
                            CommunityTab["editable"] = "0";
                            CommunityTab["canSave"] = "1";
                            CommunityTab["canSaveDynamicFields"] = "0";
                            CommunityTab["Enabled"] = "1";
                            if (true)
                            {
                                #region GuiContainer ()        CommunityBody
                                CommunityBody = new ObjectCreator("GuiContainer", "");
                                CommunityBody["margin"] = "0 0 0 0";
                                CommunityBody["padding"] = "0 0 0 0";
                                CommunityBody["anchorTop"] = "1";
                                CommunityBody["anchorBottom"] = "0";
                                CommunityBody["anchorLeft"] = "1";
                                CommunityBody["anchorRight"] = "0";
                                CommunityBody["position"] = "40 166";
                                CommunityBody["extent"] = "687 423";
                                CommunityBody["minExtent"] = "8 2";
                                CommunityBody["maxExtent"] = "1920 1080";
                                CommunityBody["horizSizing"] = "right";
                                CommunityBody["vertSizing"] = "bottom";
                                CommunityBody["profile"] = "GuiDefaultProfile";
                                CommunityBody["controlFontColor"] = "0 0 0 0";
                                CommunityBody["controlFillColor"] = "0 0 0 0";
                                CommunityBody["backgroundColor"] = "255 255 255 255";
                                CommunityBody["controlFontSize"] = "-1";
                                CommunityBody["visible"] = "1";
                                CommunityBody["active"] = "1";
                                CommunityBody["tooltipProfile"] = "GuiToolTipProfile";
                                CommunityBody["hovertime"] = "1000";
                                CommunityBody["isContainer"] = "1";
                                CommunityBody["alphaValue"] = "1";
                                CommunityBody["mouseOverAlphaValue"] = "1";
                                CommunityBody["alphaFadeTime"] = "1000";
                                CommunityBody["moveControl"] = "0";
                                CommunityBody["lockControl"] = "0";
                                CommunityBody["windowSettings"] = "1";
                                CommunityBody["alpha"] = "1";
                                CommunityBody["mouseOverAlpha"] = "1";
                                CommunityBody["alphaFade"] = "1";
                                CommunityBody["contextFontColor"] = "0";
                                CommunityBody["contextBackColor"] = "0";
                                CommunityBody["contextFillColor"] = "0";
                                CommunityBody["contextFontSize"] = "0";
                                CommunityBody["editable"] = "0";
                                CommunityBody["canSave"] = "1";
                                CommunityBody["canSaveDynamicFields"] = "0";
                                CommunityBody["Enabled"] = "0";
                                if (true)
                                {

                                    #region GuiMLTextCtrl ()        CommunityBodyText
                                    CommunityBodyText = new ObjectCreator("GuiMLTextCtrl", "");
                                    CommunityBodyText["lineSpacing"] = "2";
                                    CommunityBodyText["allowColorChars"] = "0";
                                    CommunityBodyText["maxChars"] = "-1";
                                    CommunityBodyText["text"] = "Put some sort of community information here later?";
                                    CommunityBodyText["useURLMouseCursor"] = "0";
                                    CommunityBodyText["position"] = "20 26";
                                    CommunityBodyText["extent"] = "326 14";
                                    CommunityBodyText["minExtent"] = "8 2";
                                    CommunityBodyText["maxExtent"] = "1920 1080";
                                    CommunityBodyText["horizSizing"] = "width";
                                    CommunityBodyText["vertSizing"] = "bottom";
                                    CommunityBodyText["profile"] = "GuiMLTextProfile";
                                    CommunityBodyText["controlFontColor"] = "0 0 0 0";
                                    CommunityBodyText["controlFillColor"] = "0 0 0 0";
                                    CommunityBodyText["backgroundColor"] = "255 255 255 255";
                                    CommunityBodyText["controlFontSize"] = "-1";
                                    CommunityBodyText["visible"] = "1";
                                    CommunityBodyText["active"] = "1";
                                    CommunityBodyText["tooltipProfile"] = "GuiToolTipProfile";
                                    CommunityBodyText["hovertime"] = "1000";
                                    CommunityBodyText["isContainer"] = "0";
                                    CommunityBodyText["alphaValue"] = "1";
                                    CommunityBodyText["mouseOverAlphaValue"] = "1";
                                    CommunityBodyText["alphaFadeTime"] = "1000";
                                    CommunityBodyText["windowSettings"] = "1";
                                    CommunityBodyText["alpha"] = "1";
                                    CommunityBodyText["mouseOverAlpha"] = "1";
                                    CommunityBodyText["alphaFade"] = "1";
                                    CommunityBodyText["contextFontColor"] = "0";
                                    CommunityBodyText["contextBackColor"] = "0";
                                    CommunityBodyText["contextFillColor"] = "0";
                                    CommunityBodyText["contextFontSize"] = "0";
                                    CommunityBodyText["editable"] = "0";
                                    CommunityBodyText["canSave"] = "1";
                                    CommunityBodyText["canSaveDynamicFields"] = "0";
                                    CommunityBodyText["Enabled"] = "0";
                                    #endregion

                                    CommunityBody["#CommunityBodyText"] = CommunityBodyText;

                                }
                                #endregion

                                CommunityTab["#CommunityBody"] = CommunityBody;
                            }
                            #endregion
                            #region GuiContainer (PrivateTab)        PrivateTab
                            PrivateTab = new ObjectCreator("GuiContainer", "PrivateTab");
                            PrivateTab["docking"] = "Client";
                            PrivateTab["margin"] = "0 0 0 0";
                            PrivateTab["padding"] = "0 0 0 0";
                            PrivateTab["anchorTop"] = "1";
                            PrivateTab["anchorBottom"] = "0";
                            PrivateTab["anchorLeft"] = "1";
                            PrivateTab["anchorRight"] = "0";
                            PrivateTab["position"] = "0 0";
                            PrivateTab["extent"] = "1186 616";
                            PrivateTab["minExtent"] = "8 2";
                            PrivateTab["maxExtent"] = "1920 1080";
                            PrivateTab["horizSizing"] = "left";
                            PrivateTab["vertSizing"] = "top";
                            PrivateTab["profile"] = "GuiDefaultProfile";
                            PrivateTab["controlFontColor"] = "0 0 0 0";
                            PrivateTab["controlFillColor"] = "0 0 0 0";
                            PrivateTab["backgroundColor"] = "255 255 255 255";
                            PrivateTab["controlFontSize"] = "14";
                            PrivateTab["visible"] = "0";
                            PrivateTab["active"] = "1";
                            PrivateTab["tooltipProfile"] = "GuiToolTipProfile";
                            PrivateTab["hovertime"] = "1000";
                            PrivateTab["isContainer"] = "1";
                            PrivateTab["alphaValue"] = "1";
                            PrivateTab["mouseOverAlphaValue"] = "1";
                            PrivateTab["alphaFadeTime"] = "1000";
                            PrivateTab["moveControl"] = "0";
                            PrivateTab["lockControl"] = "0";
                            PrivateTab["windowSettings"] = "1";
                            PrivateTab["alpha"] = "1";
                            PrivateTab["mouseOverAlpha"] = "1";
                            PrivateTab["alphaFade"] = "1";
                            PrivateTab["contextFontColor"] = "0";
                            PrivateTab["contextBackColor"] = "0";
                            PrivateTab["contextFillColor"] = "0";
                            PrivateTab["contextFontSize"] = "0";
                            PrivateTab["hidden"] = "1";
                            PrivateTab["editable"] = "0";
                            PrivateTab["canSave"] = "1";
                            PrivateTab["canSaveDynamicFields"] = "0";
                            PrivateTab["Enabled"] = "1";
                            if (true)
                            {
                                #region GuiContainer ()        PrivateBody
                                PrivateBody = new ObjectCreator("GuiContainer", "");
                                PrivateBody["margin"] = "0 0 0 0";
                                PrivateBody["padding"] = "0 0 0 0";
                                PrivateBody["anchorTop"] = "1";
                                PrivateBody["anchorBottom"] = "0";
                                PrivateBody["anchorLeft"] = "1";
                                PrivateBody["anchorRight"] = "0";
                                PrivateBody["position"] = "40 166";
                                PrivateBody["extent"] = "687 423";
                                PrivateBody["minExtent"] = "8 2";
                                PrivateBody["maxExtent"] = "1920 1080";
                                PrivateBody["horizSizing"] = "right";
                                PrivateBody["vertSizing"] = "bottom";
                                PrivateBody["profile"] = "GuiDefaultProfile";
                                PrivateBody["controlFontColor"] = "0 0 0 0";
                                PrivateBody["controlFillColor"] = "0 0 0 0";
                                PrivateBody["backgroundColor"] = "255 255 255 255";
                                PrivateBody["controlFontSize"] = "-1";
                                PrivateBody["visible"] = "1";
                                PrivateBody["active"] = "1";
                                PrivateBody["tooltipProfile"] = "GuiToolTipProfile";
                                PrivateBody["hovertime"] = "1000";
                                PrivateBody["isContainer"] = "1";
                                PrivateBody["alphaValue"] = "1";
                                PrivateBody["mouseOverAlphaValue"] = "1";
                                PrivateBody["alphaFadeTime"] = "1000";
                                PrivateBody["moveControl"] = "0";
                                PrivateBody["lockControl"] = "0";
                                PrivateBody["windowSettings"] = "1";
                                PrivateBody["alpha"] = "1";
                                PrivateBody["mouseOverAlpha"] = "1";
                                PrivateBody["alphaFade"] = "1";
                                PrivateBody["contextFontColor"] = "0";
                                PrivateBody["contextBackColor"] = "0";
                                PrivateBody["contextFillColor"] = "0";
                                PrivateBody["contextFontSize"] = "0";
                                PrivateBody["editable"] = "0";
                                PrivateBody["canSave"] = "1";
                                PrivateBody["canSaveDynamicFields"] = "0";
                                PrivateBody["Enabled"] = "0";
                                if (true)
                                {

                                    #region GuiMLTextCtrl ()        PrivateBodyText
                                    PrivateBodyText = new ObjectCreator("GuiMLTextCtrl", "");
                                    PrivateBodyText["lineSpacing"] = "2";
                                    PrivateBodyText["allowColorChars"] = "0";
                                    PrivateBodyText["maxChars"] = "-1";
                                    PrivateBodyText["text"] = "Eventually put the private match setup options here.";
                                    PrivateBodyText["useURLMouseCursor"] = "0";
                                    PrivateBodyText["position"] = "20 26";
                                    PrivateBodyText["extent"] = "326 14";
                                    PrivateBodyText["minExtent"] = "8 2";
                                    PrivateBodyText["maxExtent"] = "1920 1080";
                                    PrivateBodyText["horizSizing"] = "width";
                                    PrivateBodyText["vertSizing"] = "bottom";
                                    PrivateBodyText["profile"] = "GuiMLTextProfile";
                                    PrivateBodyText["controlFontColor"] = "0 0 0 0";
                                    PrivateBodyText["controlFillColor"] = "0 0 0 0";
                                    PrivateBodyText["backgroundColor"] = "255 255 255 255";
                                    PrivateBodyText["controlFontSize"] = "-1";
                                    PrivateBodyText["visible"] = "1";
                                    PrivateBodyText["active"] = "1";
                                    PrivateBodyText["tooltipProfile"] = "GuiToolTipProfile";
                                    PrivateBodyText["hovertime"] = "1000";
                                    PrivateBodyText["isContainer"] = "0";
                                    PrivateBodyText["alphaValue"] = "1";
                                    PrivateBodyText["mouseOverAlphaValue"] = "1";
                                    PrivateBodyText["alphaFadeTime"] = "1000";
                                    PrivateBodyText["windowSettings"] = "1";
                                    PrivateBodyText["alpha"] = "1";
                                    PrivateBodyText["mouseOverAlpha"] = "1";
                                    PrivateBodyText["alphaFade"] = "1";
                                    PrivateBodyText["contextFontColor"] = "0";
                                    PrivateBodyText["contextBackColor"] = "0";
                                    PrivateBodyText["contextFillColor"] = "0";
                                    PrivateBodyText["contextFontSize"] = "0";
                                    PrivateBodyText["editable"] = "0";
                                    PrivateBodyText["canSave"] = "1";
                                    PrivateBodyText["canSaveDynamicFields"] = "0";
                                    PrivateBodyText["Enabled"] = "0";
                                    #endregion

                                    PrivateBody["#PrivateBodyText"] = PrivateBodyText;

                                }
                                #endregion

                                PrivateTab["#PrivateBody"] = PrivateBody;
                            }
                            #endregion
                            #region GuiContainer (MatchmakingTab)        MatchmakingTab
                            MatchmakingTab = new ObjectCreator("GuiContainer", "MatchmakingTab");
                            MatchmakingTab["docking"] = "Client";
                            MatchmakingTab["margin"] = "0 0 0 0";
                            MatchmakingTab["padding"] = "0 0 0 0";
                            MatchmakingTab["anchorTop"] = "1";
                            MatchmakingTab["anchorBottom"] = "0";
                            MatchmakingTab["anchorLeft"] = "1";
                            MatchmakingTab["anchorRight"] = "0";
                            MatchmakingTab["position"] = "0 0";
                            MatchmakingTab["extent"] = "1186 616";
                            MatchmakingTab["minExtent"] = "8 2";
                            MatchmakingTab["maxExtent"] = "1920 1080";
                            MatchmakingTab["horizSizing"] = "left";
                            MatchmakingTab["vertSizing"] = "top";
                            MatchmakingTab["profile"] = "GuiDefaultProfile";
                            MatchmakingTab["controlFontColor"] = "0 0 0 0";
                            MatchmakingTab["controlFillColor"] = "0 0 0 0";
                            MatchmakingTab["backgroundColor"] = "255 255 255 255";
                            MatchmakingTab["controlFontSize"] = "14";
                            MatchmakingTab["visible"] = "0";
                            MatchmakingTab["active"] = "1";
                            MatchmakingTab["tooltipProfile"] = "GuiToolTipProfile";
                            MatchmakingTab["hovertime"] = "1000";
                            MatchmakingTab["isContainer"] = "1";
                            MatchmakingTab["alphaValue"] = "1";
                            MatchmakingTab["mouseOverAlphaValue"] = "1";
                            MatchmakingTab["alphaFadeTime"] = "1000";
                            MatchmakingTab["moveControl"] = "0";
                            MatchmakingTab["lockControl"] = "0";
                            MatchmakingTab["windowSettings"] = "1";
                            MatchmakingTab["alpha"] = "1";
                            MatchmakingTab["mouseOverAlpha"] = "1";
                            MatchmakingTab["alphaFade"] = "1";
                            MatchmakingTab["contextFontColor"] = "0";
                            MatchmakingTab["contextBackColor"] = "0";
                            MatchmakingTab["contextFillColor"] = "0";
                            MatchmakingTab["contextFontSize"] = "0";
                            MatchmakingTab["hidden"] = "1";
                            MatchmakingTab["editable"] = "0";
                            MatchmakingTab["canSave"] = "1";
                            MatchmakingTab["canSaveDynamicFields"] = "0";
                            MatchmakingTab["Enabled"] = "1";
                            if (true)
                            {
                                #region GuiContainer ()        MatchmakingBody
                                MatchmakingBody = new ObjectCreator("GuiContainer", "");
                                MatchmakingBody["margin"] = "0 0 0 0";
                                MatchmakingBody["padding"] = "0 0 0 0";
                                MatchmakingBody["anchorTop"] = "1";
                                MatchmakingBody["anchorBottom"] = "0";
                                MatchmakingBody["anchorLeft"] = "1";
                                MatchmakingBody["anchorRight"] = "0";
                                MatchmakingBody["position"] = "40 166";
                                MatchmakingBody["extent"] = "687 423";
                                MatchmakingBody["minExtent"] = "8 2";
                                MatchmakingBody["maxExtent"] = "1920 1080";
                                MatchmakingBody["horizSizing"] = "right";
                                MatchmakingBody["vertSizing"] = "bottom";
                                MatchmakingBody["profile"] = "GuiDefaultProfile";
                                MatchmakingBody["controlFontColor"] = "0 0 0 0";
                                MatchmakingBody["controlFillColor"] = "0 0 0 0";
                                MatchmakingBody["backgroundColor"] = "255 255 255 255";
                                MatchmakingBody["controlFontSize"] = "-1";
                                MatchmakingBody["visible"] = "1";
                                MatchmakingBody["active"] = "1";
                                MatchmakingBody["tooltipProfile"] = "GuiToolTipProfile";
                                MatchmakingBody["hovertime"] = "1000";
                                MatchmakingBody["isContainer"] = "1";
                                MatchmakingBody["alphaValue"] = "1";
                                MatchmakingBody["mouseOverAlphaValue"] = "1";
                                MatchmakingBody["alphaFadeTime"] = "1000";
                                MatchmakingBody["moveControl"] = "0";
                                MatchmakingBody["lockControl"] = "0";
                                MatchmakingBody["windowSettings"] = "1";
                                MatchmakingBody["alpha"] = "1";
                                MatchmakingBody["mouseOverAlpha"] = "1";
                                MatchmakingBody["alphaFade"] = "1";
                                MatchmakingBody["contextFontColor"] = "0";
                                MatchmakingBody["contextBackColor"] = "0";
                                MatchmakingBody["contextFillColor"] = "0";
                                MatchmakingBody["contextFontSize"] = "0";
                                MatchmakingBody["editable"] = "0";
                                MatchmakingBody["canSave"] = "1";
                                MatchmakingBody["canSaveDynamicFields"] = "0";
                                MatchmakingBody["Enabled"] = "0";
                                if (true)
                                {

                                    #region GuiMLTextCtrl ()        MatchmakingBodyText
                                    MatchmakingBodyText = new ObjectCreator("GuiMLTextCtrl", "");
                                    MatchmakingBodyText["lineSpacing"] = "2";
                                    MatchmakingBodyText["allowColorChars"] = "0";
                                    MatchmakingBodyText["maxChars"] = "-1";
                                    MatchmakingBodyText["text"] = "Matchmaking stuff here. Nothing for now.";
                                    MatchmakingBodyText["useURLMouseCursor"] = "0";
                                    MatchmakingBodyText["position"] = "20 26";
                                    MatchmakingBodyText["extent"] = "326 14";
                                    MatchmakingBodyText["minExtent"] = "8 2";
                                    MatchmakingBodyText["maxExtent"] = "1920 1080";
                                    MatchmakingBodyText["horizSizing"] = "width";
                                    MatchmakingBodyText["vertSizing"] = "bottom";
                                    MatchmakingBodyText["profile"] = "GuiMLTextProfile";
                                    MatchmakingBodyText["controlFontColor"] = "0 0 0 0";
                                    MatchmakingBodyText["controlFillColor"] = "0 0 0 0";
                                    MatchmakingBodyText["backgroundColor"] = "255 255 255 255";
                                    MatchmakingBodyText["controlFontSize"] = "-1";
                                    MatchmakingBodyText["visible"] = "1";
                                    MatchmakingBodyText["active"] = "1";
                                    MatchmakingBodyText["tooltipProfile"] = "GuiToolTipProfile";
                                    MatchmakingBodyText["hovertime"] = "1000";
                                    MatchmakingBodyText["isContainer"] = "0";
                                    MatchmakingBodyText["alphaValue"] = "1";
                                    MatchmakingBodyText["mouseOverAlphaValue"] = "1";
                                    MatchmakingBodyText["alphaFadeTime"] = "1000";
                                    MatchmakingBodyText["windowSettings"] = "1";
                                    MatchmakingBodyText["alpha"] = "1";
                                    MatchmakingBodyText["mouseOverAlpha"] = "1";
                                    MatchmakingBodyText["alphaFade"] = "1";
                                    MatchmakingBodyText["contextFontColor"] = "0";
                                    MatchmakingBodyText["contextBackColor"] = "0";
                                    MatchmakingBodyText["contextFillColor"] = "0";
                                    MatchmakingBodyText["contextFontSize"] = "0";
                                    MatchmakingBodyText["editable"] = "0";
                                    MatchmakingBodyText["canSave"] = "1";
                                    MatchmakingBodyText["canSaveDynamicFields"] = "0";
                                    MatchmakingBodyText["Enabled"] = "0";
                                    #endregion

                                    MatchmakingBody["#MatchmakingBodyText"] = MatchmakingBodyText;


                                    #region GuiWindowCtrl (ChooseLevelWindow)        oc_Newobject00020

                                    oc_Newobject00020 = new ObjectCreator("GuiWindowCtrl", "ChooseLevelWindow", typeof(ChooseLevelWindow));
                                    oc_Newobject00020["text"] = "New Window";
                                    oc_Newobject00020["resizeWidth"] = "0";
                                    oc_Newobject00020["resizeHeight"] = "0";
                                    oc_Newobject00020["canMove"] = "0";
                                    oc_Newobject00020["canClose"] = "0";
                                    oc_Newobject00020["canMinimize"] = "0";
                                    oc_Newobject00020["canMaximize"] = "0";
                                    oc_Newobject00020["canCollapse"] = "0";
                                    oc_Newobject00020["edgeSnap"] = "1";
                                    oc_Newobject00020["setTitle"] = "0";
                                    oc_Newobject00020["ShowTitle"] = "0";
                                    oc_Newobject00020["AllowPopWindow"] = "0";
                                    oc_Newobject00020["isInPopup"] = "0";
                                    oc_Newobject00020["margin"] = "0 0 0 0";
                                    oc_Newobject00020["padding"] = "0 0 0 0";
                                    oc_Newobject00020["anchorTop"] = "1";
                                    oc_Newobject00020["anchorBottom"] = "0";
                                    oc_Newobject00020["anchorLeft"] = "1";
                                    oc_Newobject00020["anchorRight"] = "0";
                                    oc_Newobject00020["position"] = "16 9";
                                    oc_Newobject00020["extent"] = "649 646";
                                    oc_Newobject00020["minExtent"] = "8 2";
                                    oc_Newobject00020["maxExtent"] = "1920 1080";
                                    oc_Newobject00020["horizSizing"] = "right";
                                    oc_Newobject00020["vertSizing"] = "bottom";
                                    oc_Newobject00020["profile"] = "GuiWindowProfile";
                                    oc_Newobject00020["controlFontColor"] = "0 0 0 0";
                                    oc_Newobject00020["controlFillColor"] = "0 0 0 0";
                                    oc_Newobject00020["backgroundColor"] = "255 255 255 255";
                                    oc_Newobject00020["controlFontSize"] = "14";
                                    oc_Newobject00020["visible"] = "1";
                                    oc_Newobject00020["active"] = "1";
                                    oc_Newobject00020["tooltipProfile"] = "GuiToolTipProfile";
                                    oc_Newobject00020["hovertime"] = "1000";
                                    oc_Newobject00020["isContainer"] = "1";
                                    oc_Newobject00020["alphaValue"] = "1";
                                    oc_Newobject00020["mouseOverAlphaValue"] = "1";
                                    oc_Newobject00020["alphaFadeTime"] = "1000";
                                    oc_Newobject00020["moveControl"] = "1";
                                    oc_Newobject00020["lockControl"] = "0";
                                    oc_Newobject00020["windowSettings"] = "1";
                                    oc_Newobject00020["alpha"] = "1";
                                    oc_Newobject00020["mouseOverAlpha"] = "1";
                                    oc_Newobject00020["alphaFade"] = "1";
                                    oc_Newobject00020["contextFontColor"] = "0";
                                    oc_Newobject00020["contextBackColor"] = "0";
                                    oc_Newobject00020["contextFillColor"] = "0";
                                    oc_Newobject00020["contextFontSize"] = "0";
                                    oc_Newobject00020["editable"] = "0";
                                    oc_Newobject00020["canSave"] = "1";
                                    oc_Newobject00020["canSaveDynamicFields"] = "0";
                                    oc_Newobject00020["Enabled"] = "1";
                                    if (true)
                                    {
                                        #region GuiBitmapCtrl ()        oc_Newobject00008

                                        oc_Newobject00008 = new ObjectCreator("GuiBitmapCtrl", "");
                                        oc_Newobject00008["wrap"] = "0";
                                        oc_Newobject00008["setBitmap"] = "0";
                                        oc_Newobject00008["position"] = "10 30";
                                        oc_Newobject00008["extent"] = "399 302";
                                        oc_Newobject00008["minExtent"] = "8 2";
                                        oc_Newobject00008["maxExtent"] = "1920 1080";
                                        oc_Newobject00008["horizSizing"] = "windowRelative";
                                        oc_Newobject00008["vertSizing"] = "windowRelative";
                                        oc_Newobject00008["profile"] = "GuiDefaultProfile";
                                        oc_Newobject00008["controlFontColor"] = "0 0 0 0";
                                        oc_Newobject00008["controlFillColor"] = "0 0 0 0";
                                        oc_Newobject00008["backgroundColor"] = "255 255 255 255";
                                        oc_Newobject00008["controlFontSize"] = "14";
                                        oc_Newobject00008["visible"] = "1";
                                        oc_Newobject00008["active"] = "1";
                                        oc_Newobject00008["tooltipProfile"] = "GuiToolTipProfile";
                                        oc_Newobject00008["hovertime"] = "1000";
                                        oc_Newobject00008["isContainer"] = "0";
                                        oc_Newobject00008["alphaValue"] = "1";
                                        oc_Newobject00008["mouseOverAlphaValue"] = "1";
                                        oc_Newobject00008["alphaFadeTime"] = "1000";
                                        oc_Newobject00008["moveControl"] = "0";
                                        oc_Newobject00008["lockControl"] = "0";
                                        oc_Newobject00008["windowSettings"] = "1";
                                        oc_Newobject00008["alpha"] = "1";
                                        oc_Newobject00008["mouseOverAlpha"] = "1";
                                        oc_Newobject00008["alphaFade"] = "1";
                                        oc_Newobject00008["contextFontColor"] = "0";
                                        oc_Newobject00008["contextBackColor"] = "0";
                                        oc_Newobject00008["contextFillColor"] = "0";
                                        oc_Newobject00008["contextFontSize"] = "0";
                                        oc_Newobject00008["internalName"] = "CurrentPreview";
                                        oc_Newobject00008["editable"] = "0";
                                        oc_Newobject00008["canSave"] = "1";
                                        oc_Newobject00008["canSaveDynamicFields"] = "1";
                                        oc_Newobject00008["Enabled"] = "1";

                                        #endregion

                                        oc_Newobject00020["#Newobject00008"] = oc_Newobject00008;

                                        #region GuiTextCtrl ()        oc_Newobject00009

                                        oc_Newobject00009 = new ObjectCreator("GuiTextCtrl", "");
                                        oc_Newobject00009["maxLength"] = "255";
                                        oc_Newobject00009["margin"] = "0 0 0 0";
                                        oc_Newobject00009["padding"] = "0 0 0 0";
                                        oc_Newobject00009["anchorTop"] = "1";
                                        oc_Newobject00009["anchorBottom"] = "0";
                                        oc_Newobject00009["anchorLeft"] = "1";
                                        oc_Newobject00009["anchorRight"] = "0";
                                        oc_Newobject00009["position"] = "419 30";
                                        oc_Newobject00009["extent"] = "165 19";
                                        oc_Newobject00009["minExtent"] = "8 8";
                                        oc_Newobject00009["maxExtent"] = "1920 1080";
                                        oc_Newobject00009["horizSizing"] = "windowRelative";
                                        oc_Newobject00009["vertSizing"] = "windowRelative";
                                        oc_Newobject00009["profile"] = "GuiMediumTextProfile";
                                        oc_Newobject00009["controlFontColor"] = "0 0 0 0";
                                        oc_Newobject00009["controlFillColor"] = "0 0 0 0";
                                        oc_Newobject00009["backgroundColor"] = "255 255 255 255";
                                        oc_Newobject00009["controlFontSize"] = "24";
                                        oc_Newobject00009["visible"] = "1";
                                        oc_Newobject00009["active"] = "1";
                                        oc_Newobject00009["tooltipProfile"] = "GuiToolTipProfile";
                                        oc_Newobject00009["hovertime"] = "1000";
                                        oc_Newobject00009["isContainer"] = "0";
                                        oc_Newobject00009["alphaValue"] = "1";
                                        oc_Newobject00009["mouseOverAlphaValue"] = "1";
                                        oc_Newobject00009["alphaFadeTime"] = "1000";
                                        oc_Newobject00009["moveControl"] = "0";
                                        oc_Newobject00009["lockControl"] = "0";
                                        oc_Newobject00009["windowSettings"] = "1";
                                        oc_Newobject00009["alpha"] = "1";
                                        oc_Newobject00009["mouseOverAlpha"] = "1";
                                        oc_Newobject00009["alphaFade"] = "1";
                                        oc_Newobject00009["contextFontColor"] = "0";
                                        oc_Newobject00009["contextBackColor"] = "0";
                                        oc_Newobject00009["contextFillColor"] = "0";
                                        oc_Newobject00009["contextFontSize"] = "0";
                                        oc_Newobject00009["internalName"] = "LevelName";
                                        oc_Newobject00009["editable"] = "0";
                                        oc_Newobject00009["canSave"] = "1";
                                        oc_Newobject00009["canSaveDynamicFields"] = "0";
                                        oc_Newobject00009["Enabled"] = "1";

                                        #endregion

                                        oc_Newobject00020["#Newobject00009"] = oc_Newobject00009;

                                        #region GuiTextCtrl ()        oc_Newobject00010

                                        oc_Newobject00010 = new ObjectCreator("GuiTextCtrl", "");
                                        oc_Newobject00010["text"] = "Description:";
                                        oc_Newobject00010["maxLength"] = "255";
                                        oc_Newobject00010["margin"] = "0 0 0 0";
                                        oc_Newobject00010["padding"] = "0 0 0 0";
                                        oc_Newobject00010["anchorTop"] = "1";
                                        oc_Newobject00010["anchorBottom"] = "0";
                                        oc_Newobject00010["anchorLeft"] = "1";
                                        oc_Newobject00010["anchorRight"] = "0";
                                        oc_Newobject00010["position"] = "419 50";
                                        oc_Newobject00010["extent"] = "72 19";
                                        oc_Newobject00010["minExtent"] = "8 8";
                                        oc_Newobject00010["maxExtent"] = "1920 1080";
                                        oc_Newobject00010["horizSizing"] = "windowRelative";
                                        oc_Newobject00010["vertSizing"] = "windowRelative";
                                        oc_Newobject00010["profile"] = "GuiTextProfile";
                                        oc_Newobject00010["controlFontColor"] = "0 0 0 0";
                                        oc_Newobject00010["controlFillColor"] = "0 0 0 0";
                                        oc_Newobject00010["backgroundColor"] = "255 255 255 255";
                                        oc_Newobject00010["controlFontSize"] = "14";
                                        oc_Newobject00010["visible"] = "1";
                                        oc_Newobject00010["active"] = "1";
                                        oc_Newobject00010["tooltipProfile"] = "GuiToolTipProfile";
                                        oc_Newobject00010["hovertime"] = "1000";
                                        oc_Newobject00010["isContainer"] = "0";
                                        oc_Newobject00010["alphaValue"] = "1";
                                        oc_Newobject00010["mouseOverAlphaValue"] = "1";
                                        oc_Newobject00010["alphaFadeTime"] = "1000";
                                        oc_Newobject00010["moveControl"] = "0";
                                        oc_Newobject00010["lockControl"] = "0";
                                        oc_Newobject00010["windowSettings"] = "1";
                                        oc_Newobject00010["alpha"] = "1";
                                        oc_Newobject00010["mouseOverAlpha"] = "1";
                                        oc_Newobject00010["alphaFade"] = "1";
                                        oc_Newobject00010["contextFontColor"] = "0";
                                        oc_Newobject00010["contextBackColor"] = "0";
                                        oc_Newobject00010["contextFillColor"] = "0";
                                        oc_Newobject00010["contextFontSize"] = "0";
                                        oc_Newobject00010["editable"] = "0";
                                        oc_Newobject00010["canSave"] = "1";
                                        oc_Newobject00010["canSaveDynamicFields"] = "0";
                                        oc_Newobject00010["Enabled"] = "1";

                                        #endregion

                                        oc_Newobject00020["#Newobject00010"] = oc_Newobject00010;

                                        #region GuiMLTextCtrl ()        oc_Newobject00011

                                        oc_Newobject00011 = new ObjectCreator("GuiMLTextCtrl", "");
                                        oc_Newobject00011["lineSpacing"] = "2";
                                        oc_Newobject00011["allowColorChars"] = "0";
                                        oc_Newobject00011["maxChars"] = "-1";
                                        oc_Newobject00011["useURLMouseCursor"] = "0";
                                        oc_Newobject00011["position"] = "419 74";
                                        oc_Newobject00011["extent"] = "165 14";
                                        oc_Newobject00011["minExtent"] = "8 8";
                                        oc_Newobject00011["maxExtent"] = "1920 1080";
                                        oc_Newobject00011["horizSizing"] = "windowRelative";
                                        oc_Newobject00011["vertSizing"] = "windowRelative";
                                        oc_Newobject00011["profile"] = "GuiMLTextProfile";
                                        oc_Newobject00011["controlFontColor"] = "0 0 0 0";
                                        oc_Newobject00011["controlFillColor"] = "0 0 0 0";
                                        oc_Newobject00011["backgroundColor"] = "255 255 255 255";
                                        oc_Newobject00011["controlFontSize"] = "14";
                                        oc_Newobject00011["visible"] = "1";
                                        oc_Newobject00011["active"] = "1";
                                        oc_Newobject00011["tooltipProfile"] = "GuiToolTipProfile";
                                        oc_Newobject00011["hovertime"] = "1000";
                                        oc_Newobject00011["isContainer"] = "0";
                                        oc_Newobject00011["alphaValue"] = "1";
                                        oc_Newobject00011["mouseOverAlphaValue"] = "1";
                                        oc_Newobject00011["alphaFadeTime"] = "1000";
                                        oc_Newobject00011["windowSettings"] = "1";
                                        oc_Newobject00011["alpha"] = "1";
                                        oc_Newobject00011["mouseOverAlpha"] = "1";
                                        oc_Newobject00011["alphaFade"] = "1";
                                        oc_Newobject00011["contextFontColor"] = "0";
                                        oc_Newobject00011["contextBackColor"] = "0";
                                        oc_Newobject00011["contextFillColor"] = "0";
                                        oc_Newobject00011["contextFontSize"] = "0";
                                        oc_Newobject00011["internalName"] = "LevelDescription";
                                        oc_Newobject00011["editable"] = "0";
                                        oc_Newobject00011["canSave"] = "1";
                                        oc_Newobject00011["canSaveDynamicFields"] = "0";
                                        oc_Newobject00011["Enabled"] = "1";

                                        #endregion

                                        oc_Newobject00020["#Newobject00011"] = oc_Newobject00011;

                                        #region GuiCheckBoxCtrl ()        oc_Newobject00012

                                        oc_Newobject00012 = new ObjectCreator("GuiCheckBoxCtrl", "");
                                        oc_Newobject00012["text"] = "Host";
                                        oc_Newobject00012["groupNum"] = "-1";
                                        oc_Newobject00012["buttonType"] = "ToggleButton";
                                        oc_Newobject00012["useMouseEvents"] = "0";
                                        oc_Newobject00012["position"] = "431 140";
                                        oc_Newobject00012["extent"] = "45 22";
                                        oc_Newobject00012["minExtent"] = "8 8";
                                        oc_Newobject00012["maxExtent"] = "1920 1080";
                                        oc_Newobject00012["horizSizing"] = "windowRelative";
                                        oc_Newobject00012["vertSizing"] = "windowRelative";
                                        oc_Newobject00012["profile"] = "GuiCheckBoxProfile";
                                        oc_Newobject00012["controlFontColor"] = "0 0 0 0";
                                        oc_Newobject00012["backgroundColor"] = "255 255 255 255";
                                        oc_Newobject00012["controlFontSize"] = "14";
                                        oc_Newobject00012["visible"] = "1";
                                        oc_Newobject00012["active"] = "1";
                                        oc_Newobject00012["variable"] = "pref::HostMultiPlayer";
                                        oc_Newobject00012["tooltipProfile"] = "GuiToolTipProfile";
                                        oc_Newobject00012["hovertime"] = "1000";
                                        oc_Newobject00012["isContainer"] = "0";
                                        oc_Newobject00012["alphaValue"] = "1";
                                        oc_Newobject00012["mouseOverAlphaValue"] = "1";
                                        oc_Newobject00012["alphaFadeTime"] = "1000";
                                        oc_Newobject00012["windowSettings"] = "1";
                                        oc_Newobject00012["alpha"] = "1";
                                        oc_Newobject00012["mouseOverAlpha"] = "1";
                                        oc_Newobject00012["alphaFade"] = "1";
                                        oc_Newobject00012["contextFontColor"] = "0";
                                        oc_Newobject00012["contextBackColor"] = "0";
                                        oc_Newobject00012["contextFontSize"] = "0";
                                        oc_Newobject00012["editable"] = "0";
                                        oc_Newobject00012["canSave"] = "1";
                                        oc_Newobject00012["canSaveDynamicFields"] = "0";
                                        oc_Newobject00012["Enabled"] = "1";

                                        #endregion

                                        oc_Newobject00020["#Newobject00012"] = oc_Newobject00012;

                                        #region GuiCheckBoxCtrl ()        oc_Newobject00013

                                        oc_Newobject00013 = new ObjectCreator("GuiCheckBoxCtrl", "");
                                        oc_Newobject00013["text"] = "Open in World Editor";
                                        oc_Newobject00013["groupNum"] = "10";
                                        oc_Newobject00013["buttonType"] = "RadioButton";
                                        oc_Newobject00013["useMouseEvents"] = "0";
                                        oc_Newobject00013["position"] = "431 166";
                                        oc_Newobject00013["extent"] = "119 22";
                                        oc_Newobject00013["minExtent"] = "8 8";
                                        oc_Newobject00013["maxExtent"] = "1920 1080";
                                        oc_Newobject00013["horizSizing"] = "windowRelative";
                                        oc_Newobject00013["vertSizing"] = "windowRelative";
                                        oc_Newobject00013["profile"] = "GuiCheckBoxProfile";
                                        oc_Newobject00013["controlFontColor"] = "0 0 0 0";
                                        oc_Newobject00013["backgroundColor"] = "255 255 255 255";
                                        oc_Newobject00013["controlFontSize"] = "14";
                                        oc_Newobject00013["visible"] = "1";
                                        oc_Newobject00013["active"] = "1";
                                        oc_Newobject00013["tooltipProfile"] = "GuiToolTipProfile";
                                        oc_Newobject00013["hovertime"] = "1000";
                                        oc_Newobject00013["isContainer"] = "0";
                                        oc_Newobject00013["alphaValue"] = "1";
                                        oc_Newobject00013["mouseOverAlphaValue"] = "1";
                                        oc_Newobject00013["alphaFadeTime"] = "1000";
                                        oc_Newobject00013["windowSettings"] = "1";
                                        oc_Newobject00013["alpha"] = "1";
                                        oc_Newobject00013["mouseOverAlpha"] = "1";
                                        oc_Newobject00013["alphaFade"] = "1";
                                        oc_Newobject00013["contextFontColor"] = "0";
                                        oc_Newobject00013["contextBackColor"] = "0";
                                        oc_Newobject00013["contextFontSize"] = "0";
                                        oc_Newobject00013["editable"] = "0";
                                        oc_Newobject00013["canSave"] = "1";
                                        oc_Newobject00013["canSaveDynamicFields"] = "0";
                                        oc_Newobject00013["Enabled"] = "1";

                                        #endregion

                                        oc_Newobject00020["#Newobject00013"] = oc_Newobject00013;

                                        #region GuiCheckBoxCtrl ()        oc_Newobject00014

                                        oc_Newobject00014 = new ObjectCreator("GuiCheckBoxCtrl", "");
                                        oc_Newobject00014["text"] = "Play";
                                        oc_Newobject00014["internalName"] = "PlayButton";
                                        oc_Newobject00014["groupNum"] = "10";
                                        oc_Newobject00014["buttonType"] = "RadioButton";
                                        oc_Newobject00014["useMouseEvents"] = "0";
                                        oc_Newobject00014["position"] = "431 192";
                                        oc_Newobject00014["extent"] = "119 22";
                                        oc_Newobject00014["minExtent"] = "8 8";
                                        oc_Newobject00014["maxExtent"] = "1920 1080";
                                        oc_Newobject00014["horizSizing"] = "windowRelative";
                                        oc_Newobject00014["vertSizing"] = "windowRelative";
                                        oc_Newobject00014["profile"] = "GuiCheckBoxProfile";
                                        oc_Newobject00014["controlFontColor"] = "0 0 0 0";
                                        oc_Newobject00014["backgroundColor"] = "255 255 255 255";
                                        oc_Newobject00014["controlFontSize"] = "14";
                                        oc_Newobject00014["visible"] = "1";
                                        oc_Newobject00014["active"] = "1";
                                        oc_Newobject00014["tooltipProfile"] = "GuiToolTipProfile";
                                        oc_Newobject00014["hovertime"] = "1000";
                                        oc_Newobject00014["isContainer"] = "0";
                                        oc_Newobject00014["alphaValue"] = "1";
                                        oc_Newobject00014["mouseOverAlphaValue"] = "1";
                                        oc_Newobject00014["alphaFadeTime"] = "1000";
                                        oc_Newobject00014["windowSettings"] = "1";
                                        oc_Newobject00014["alpha"] = "1";
                                        oc_Newobject00014["mouseOverAlpha"] = "1";
                                        oc_Newobject00014["alphaFade"] = "1";
                                        oc_Newobject00014["contextFontColor"] = "0";
                                        oc_Newobject00014["contextBackColor"] = "0";
                                        oc_Newobject00014["contextFontSize"] = "0";
                                        oc_Newobject00014["editable"] = "0";
                                        oc_Newobject00014["canSave"] = "1";
                                        oc_Newobject00014["canSaveDynamicFields"] = "0";
                                        oc_Newobject00014["Enabled"] = "1";

                                        #endregion

                                        oc_Newobject00020["#Newobject00014"] = oc_Newobject00014;

                                        #region GuiButtonCtrl (ChooseLevelDlgGoBtn)        oc_Newobject00015

                                        oc_Newobject00015 = new ObjectCreator("GuiButtonCtrl", "ChooseLevelDlgGoBtn", typeof(chooseLevelDlgGoBtn));
                                        oc_Newobject00015["text"] = "Go!";
                                        oc_Newobject00015["groupNum"] = "-1";
                                        oc_Newobject00015["buttonType"] = "PushButton";
                                        oc_Newobject00015["useMouseEvents"] = "1";
                                        oc_Newobject00015["position"] = "458 288";
                                        oc_Newobject00015["extent"] = "142 56";
                                        oc_Newobject00015["minExtent"] = "8 8";
                                        oc_Newobject00015["maxExtent"] = "1920 1080";
                                        oc_Newobject00015["horizSizing"] = "windowRelative";
                                        oc_Newobject00015["vertSizing"] = "windowRelative";
                                        oc_Newobject00015["profile"] = "GuiMenuButtonProfile";
                                        oc_Newobject00015["controlFontColor"] = "0 0 0 0";
                                        oc_Newobject00015["backgroundColor"] = "255 255 255 255";
                                        oc_Newobject00015["controlFontSize"] = "18";
                                        oc_Newobject00015["visible"] = "1";
                                        oc_Newobject00015["active"] = "1";
                                        oc_Newobject00015["tooltipProfile"] = "GuiToolTipProfile";
                                        oc_Newobject00015["hovertime"] = "1000";
                                        oc_Newobject00015["isContainer"] = "0";
                                        oc_Newobject00015["alphaValue"] = "1";
                                        oc_Newobject00015["mouseOverAlphaValue"] = "1";
                                        oc_Newobject00015["alphaFadeTime"] = "1000";
                                        oc_Newobject00015["windowSettings"] = "1";
                                        oc_Newobject00015["alpha"] = "1";
                                        oc_Newobject00015["mouseOverAlpha"] = "1";
                                        oc_Newobject00015["alphaFade"] = "1";
                                        oc_Newobject00015["contextFontColor"] = "0";
                                        oc_Newobject00015["contextBackColor"] = "0";
                                        oc_Newobject00015["contextFontSize"] = "0";
                                        oc_Newobject00015["editable"] = "0";
                                        oc_Newobject00015["canSave"] = "1";
                                        oc_Newobject00015["canSaveDynamicFields"] = "0";
                                        oc_Newobject00015["Enabled"] = "1";

                                        #endregion

                                        oc_Newobject00020["#Newobject00015"] = oc_Newobject00015;

                                        #region GuiBitmapButtonCtrl ()        oc_Newobject00016

                                        oc_Newobject00016 = new ObjectCreator("GuiBitmapButtonCtrl", "");
                                        oc_Newobject00016["bitmap"] = "art/gui/previous-button";
                                        oc_Newobject00016["bitmapMode"] = "Stretched";
                                        oc_Newobject00016["autoFitExtents"] = "0";
                                        oc_Newobject00016["useModifiers"] = "0";
                                        oc_Newobject00016["useStates"] = "1";
                                        oc_Newobject00016["groupNum"] = "-1";
                                        oc_Newobject00016["buttonType"] = "PushButton";
                                        oc_Newobject00016["useMouseEvents"] = "0";
                                        oc_Newobject00016["position"] = "10 343";
                                        oc_Newobject00016["extent"] = "11 81";
                                        oc_Newobject00016["minExtent"] = "8 2";
                                        oc_Newobject00016["maxExtent"] = "1920 1080";
                                        oc_Newobject00016["horizSizing"] = "windowRelative";
                                        oc_Newobject00016["vertSizing"] = "windowRelative";
                                        oc_Newobject00016["profile"] = "GuiDefaultProfile";
                                        oc_Newobject00016["controlFontColor"] = "0 0 0 0";
                                        oc_Newobject00016["backgroundColor"] = "255 255 255 255";
                                        oc_Newobject00016["controlFontSize"] = "14";
                                        oc_Newobject00016["visible"] = "1";
                                        oc_Newobject00016["active"] = "1";
                                        oc_Newobject00016["command"] = "ChooseLevelWindow.previousPreviews();";
                                        oc_Newobject00016["tooltipProfile"] = "GuiToolTipProfile";
                                        oc_Newobject00016["hovertime"] = "1000";
                                        oc_Newobject00016["isContainer"] = "0";
                                        oc_Newobject00016["alphaValue"] = "1";
                                        oc_Newobject00016["mouseOverAlphaValue"] = "1";
                                        oc_Newobject00016["alphaFadeTime"] = "1000";
                                        oc_Newobject00016["windowSettings"] = "1";
                                        oc_Newobject00016["alpha"] = "1";
                                        oc_Newobject00016["mouseOverAlpha"] = "1";
                                        oc_Newobject00016["alphaFade"] = "1";
                                        oc_Newobject00016["contextFontColor"] = "0";
                                        oc_Newobject00016["contextBackColor"] = "0";
                                        oc_Newobject00016["contextFontSize"] = "0";
                                        oc_Newobject00016["internalName"] = "PreviousSmallPreviews";
                                        oc_Newobject00016["editable"] = "0";
                                        oc_Newobject00016["canSave"] = "1";
                                        oc_Newobject00016["canSaveDynamicFields"] = "1";
                                        oc_Newobject00016["Enabled"] = "1";
                                        oc_Newobject00016["wrap"] = "0";

                                        #endregion

                                        oc_Newobject00020["#Newobject00016"] = oc_Newobject00016;

                                        #region GuiDynamicCtrlArrayControl ()        oc_Newobject00017

                                        oc_Newobject00017 = new ObjectCreator("GuiDynamicCtrlArrayControl", "");
                                        oc_Newobject00017["colCount"] = "3";
                                        oc_Newobject00017["internalName"] = "SmallPreviews";
                                        oc_Newobject00017["position"] = "24 343";
                                        oc_Newobject00017["extent"] = "600 81";
                                        oc_Newobject00017["rowCount"] = "1";
                                        oc_Newobject00017["colSpacing"] = "3";
                                        oc_Newobject00017["autoCellSize"] = "1";
                                        oc_Newobject00017["fillFirstRow"] = "0";

                                        #endregion

                                        oc_Newobject00020["#Newobject00017"] = oc_Newobject00017;

                                        #region GuiBitmapButtonCtrl ()        oc_Newobject00018

                                        oc_Newobject00018 = new ObjectCreator("GuiBitmapButtonCtrl", "");
                                        oc_Newobject00018["bitmap"] = "art/gui/next-button";
                                        oc_Newobject00018["bitmapMode"] = "Stretched";
                                        oc_Newobject00018["autoFitExtents"] = "0";
                                        oc_Newobject00018["useModifiers"] = "0";
                                        oc_Newobject00018["useStates"] = "1";
                                        oc_Newobject00018["groupNum"] = "-1";
                                        oc_Newobject00018["buttonType"] = "PushButton";
                                        oc_Newobject00018["useMouseEvents"] = "0";
                                        oc_Newobject00018["position"] = "579 343";
                                        oc_Newobject00018["extent"] = "11 81";
                                        oc_Newobject00018["minExtent"] = "8 2";
                                        oc_Newobject00018["maxExtent"] = "1920 1080";
                                        oc_Newobject00018["horizSizing"] = "right";
                                        oc_Newobject00018["vertSizing"] = "bottom";
                                        oc_Newobject00018["profile"] = "GuiDefaultProfile";
                                        oc_Newobject00018["controlFontColor"] = "0 0 0 0";
                                        oc_Newobject00018["backgroundColor"] = "255 255 255 255";
                                        oc_Newobject00018["controlFontSize"] = "14";
                                        oc_Newobject00018["visible"] = "1";
                                        oc_Newobject00018["active"] = "1";
                                        oc_Newobject00018["command"] = "ChooseLevelWindow.nextPreviews();";
                                        oc_Newobject00018["tooltipProfile"] = "GuiToolTipProfile";
                                        oc_Newobject00018["hovertime"] = "1000";
                                        oc_Newobject00018["isContainer"] = "0";
                                        oc_Newobject00018["alphaValue"] = "1";
                                        oc_Newobject00018["mouseOverAlphaValue"] = "1";
                                        oc_Newobject00018["alphaFadeTime"] = "1000";
                                        oc_Newobject00018["windowSettings"] = "1";
                                        oc_Newobject00018["alpha"] = "1";
                                        oc_Newobject00018["mouseOverAlpha"] = "1";
                                        oc_Newobject00018["alphaFade"] = "1";
                                        oc_Newobject00018["contextFontColor"] = "0";
                                        oc_Newobject00018["contextBackColor"] = "0";
                                        oc_Newobject00018["contextFontSize"] = "0";
                                        oc_Newobject00018["internalName"] = "NextSmallPreviews";
                                        oc_Newobject00018["editable"] = "0";
                                        oc_Newobject00018["canSave"] = "1";
                                        oc_Newobject00018["canSaveDynamicFields"] = "1";
                                        oc_Newobject00018["Enabled"] = "1";
                                        oc_Newobject00018["wrap"] = "0";

                                        #endregion

                                        oc_Newobject00020["#Newobject00018"] = oc_Newobject00018;

                                        #region GuiTextListCtrl (CL_levelList)        oc_Newobject00019

                                        oc_Newobject00019 = new ObjectCreator("GuiTextListCtrl", "CL_levelList");
                                        oc_Newobject00019["columns"] = "0";
                                        oc_Newobject00019["fitParentWidth"] = "1";
                                        oc_Newobject00019["clipColumnText"] = "0";
                                        oc_Newobject00019["position"] = "1 1";
                                        oc_Newobject00019["extent"] = "80 8";
                                        oc_Newobject00019["minExtent"] = "8 8";
                                        oc_Newobject00019["maxExtent"] = "1920 1080";
                                        oc_Newobject00019["horizSizing"] = "right";
                                        oc_Newobject00019["vertSizing"] = "bottom";
                                        oc_Newobject00019["profile"] = "GuiTextArrayProfile";
                                        oc_Newobject00019["controlFontColor"] = "0 0 0 0";
                                        oc_Newobject00019["controlFillColor"] = "0 0 0 0";
                                        oc_Newobject00019["backgroundColor"] = "255 255 255 255";
                                        oc_Newobject00019["controlFontSize"] = "14";
                                        oc_Newobject00019["visible"] = "1";
                                        oc_Newobject00019["active"] = "1";
                                        oc_Newobject00019["tooltipProfile"] = "GuiToolTipProfile";
                                        oc_Newobject00019["hovertime"] = "1000";
                                        oc_Newobject00019["isContainer"] = "1";
                                        oc_Newobject00019["alphaValue"] = "1";
                                        oc_Newobject00019["mouseOverAlphaValue"] = "1";
                                        oc_Newobject00019["alphaFadeTime"] = "1000";
                                        oc_Newobject00019["moveControl"] = "0";
                                        oc_Newobject00019["lockControl"] = "0";
                                        oc_Newobject00019["windowSettings"] = "1";
                                        oc_Newobject00019["alpha"] = "1";
                                        oc_Newobject00019["mouseOverAlpha"] = "1";
                                        oc_Newobject00019["alphaFade"] = "1";
                                        oc_Newobject00019["contextFontColor"] = "0";
                                        oc_Newobject00019["contextBackColor"] = "0";
                                        oc_Newobject00019["contextFillColor"] = "0";
                                        oc_Newobject00019["contextFontSize"] = "0";
                                        oc_Newobject00019["hidden"] = "1";
                                        oc_Newobject00019["editable"] = "0";
                                        oc_Newobject00019["canSave"] = "1";
                                        oc_Newobject00019["canSaveDynamicFields"] = "0";
                                        oc_Newobject00019["Enabled"] = "1";

                                        #endregion

                                        oc_Newobject00020["#Newobject00019"] = oc_Newobject00019;
                                    }

                                    #endregion

                                    MatchmakingBody["#Newobject00020"] = oc_Newobject00020;

                                }
                                #endregion

                                MatchmakingTab["#MatchmakingBody"] = MatchmakingBody;
                            }
                            #endregion
                            #region GuiContainer (StoreTab)        StoreTab
                            StoreTab = new ObjectCreator("GuiContainer", "StoreTab");
                            StoreTab["docking"] = "Client";
                            StoreTab["margin"] = "0 0 0 0";
                            StoreTab["padding"] = "0 0 0 0";
                            StoreTab["anchorTop"] = "1";
                            StoreTab["anchorBottom"] = "0";
                            StoreTab["anchorLeft"] = "1";
                            StoreTab["anchorRight"] = "0";
                            StoreTab["position"] = "0 0";
                            StoreTab["extent"] = "1186 616";
                            StoreTab["minExtent"] = "8 2";
                            StoreTab["maxExtent"] = "1920 1080";
                            StoreTab["horizSizing"] = "left";
                            StoreTab["vertSizing"] = "top";
                            StoreTab["profile"] = "GuiDefaultProfile";
                            StoreTab["controlFontColor"] = "0 0 0 0";
                            StoreTab["controlFillColor"] = "0 0 0 0";
                            StoreTab["backgroundColor"] = "255 255 255 255";
                            StoreTab["controlFontSize"] = "14";
                            StoreTab["visible"] = "0";
                            StoreTab["active"] = "1";
                            StoreTab["tooltipProfile"] = "GuiToolTipProfile";
                            StoreTab["hovertime"] = "1000";
                            StoreTab["isContainer"] = "1";
                            StoreTab["alphaValue"] = "1";
                            StoreTab["mouseOverAlphaValue"] = "1";
                            StoreTab["alphaFadeTime"] = "1000";
                            StoreTab["moveControl"] = "0";
                            StoreTab["lockControl"] = "0";
                            StoreTab["windowSettings"] = "1";
                            StoreTab["alpha"] = "1";
                            StoreTab["mouseOverAlpha"] = "1";
                            StoreTab["alphaFade"] = "1";
                            StoreTab["contextFontColor"] = "0";
                            StoreTab["contextBackColor"] = "0";
                            StoreTab["contextFillColor"] = "0";
                            StoreTab["contextFontSize"] = "0";
                            StoreTab["hidden"] = "1";
                            StoreTab["editable"] = "0";
                            StoreTab["canSave"] = "1";
                            StoreTab["canSaveDynamicFields"] = "0";
                            StoreTab["Enabled"] = "1";
                            if (true)
                            {
                                #region GuiContainer ()        StoreBody
                                StoreBody = new ObjectCreator("GuiContainer", "");
                                StoreBody["margin"] = "0 0 0 0";
                                StoreBody["padding"] = "0 0 0 0";
                                StoreBody["anchorTop"] = "1";
                                StoreBody["anchorBottom"] = "0";
                                StoreBody["anchorLeft"] = "1";
                                StoreBody["anchorRight"] = "0";
                                StoreBody["position"] = "40 166";
                                StoreBody["extent"] = "687 423";
                                StoreBody["minExtent"] = "8 2";
                                StoreBody["maxExtent"] = "1920 1080";
                                StoreBody["horizSizing"] = "right";
                                StoreBody["vertSizing"] = "bottom";
                                StoreBody["profile"] = "GuiDefaultProfile";
                                StoreBody["controlFontColor"] = "0 0 0 0";
                                StoreBody["controlFillColor"] = "0 0 0 0";
                                StoreBody["backgroundColor"] = "255 255 255 255";
                                StoreBody["controlFontSize"] = "-1";
                                StoreBody["visible"] = "1";
                                StoreBody["active"] = "1";
                                StoreBody["tooltipProfile"] = "GuiToolTipProfile";
                                StoreBody["hovertime"] = "1000";
                                StoreBody["isContainer"] = "1";
                                StoreBody["alphaValue"] = "1";
                                StoreBody["mouseOverAlphaValue"] = "1";
                                StoreBody["alphaFadeTime"] = "1000";
                                StoreBody["moveControl"] = "0";
                                StoreBody["lockControl"] = "0";
                                StoreBody["windowSettings"] = "1";
                                StoreBody["alpha"] = "1";
                                StoreBody["mouseOverAlpha"] = "1";
                                StoreBody["alphaFade"] = "1";
                                StoreBody["contextFontColor"] = "0";
                                StoreBody["contextBackColor"] = "0";
                                StoreBody["contextFillColor"] = "0";
                                StoreBody["contextFontSize"] = "0";
                                StoreBody["editable"] = "0";
                                StoreBody["canSave"] = "1";
                                StoreBody["canSaveDynamicFields"] = "0";
                                StoreBody["Enabled"] = "0";
                                if (true)
                                {

                                    #region GuiMLTextCtrl ()        StoreBodyText
                                    StoreBodyText = new ObjectCreator("GuiMLTextCtrl", "");
                                    StoreBodyText["lineSpacing"] = "2";
                                    StoreBodyText["allowColorChars"] = "0";
                                    StoreBodyText["maxChars"] = "-1";
                                    StoreBodyText["text"] = "May not even need this page. Here if we need it either way. Can\'t hurt, right?";
                                    StoreBodyText["useURLMouseCursor"] = "0";
                                    StoreBodyText["position"] = "20 26";
                                    StoreBodyText["extent"] = "326 14";
                                    StoreBodyText["minExtent"] = "8 2";
                                    StoreBodyText["maxExtent"] = "1920 1080";
                                    StoreBodyText["horizSizing"] = "width";
                                    StoreBodyText["vertSizing"] = "bottom";
                                    StoreBodyText["profile"] = "GuiMLTextProfile";
                                    StoreBodyText["controlFontColor"] = "0 0 0 0";
                                    StoreBodyText["controlFillColor"] = "0 0 0 0";
                                    StoreBodyText["backgroundColor"] = "255 255 255 255";
                                    StoreBodyText["controlFontSize"] = "-1";
                                    StoreBodyText["visible"] = "1";
                                    StoreBodyText["active"] = "1";
                                    StoreBodyText["tooltipProfile"] = "GuiToolTipProfile";
                                    StoreBodyText["hovertime"] = "1000";
                                    StoreBodyText["isContainer"] = "0";
                                    StoreBodyText["alphaValue"] = "1";
                                    StoreBodyText["mouseOverAlphaValue"] = "1";
                                    StoreBodyText["alphaFadeTime"] = "1000";
                                    StoreBodyText["windowSettings"] = "1";
                                    StoreBodyText["alpha"] = "1";
                                    StoreBodyText["mouseOverAlpha"] = "1";
                                    StoreBodyText["alphaFade"] = "1";
                                    StoreBodyText["contextFontColor"] = "0";
                                    StoreBodyText["contextBackColor"] = "0";
                                    StoreBodyText["contextFillColor"] = "0";
                                    StoreBodyText["contextFontSize"] = "0";
                                    StoreBodyText["editable"] = "0";
                                    StoreBodyText["canSave"] = "1";
                                    StoreBodyText["canSaveDynamicFields"] = "0";
                                    StoreBodyText["Enabled"] = "0";
                                    #endregion

                                    StoreBody["#StoreBodyText"] = StoreBodyText;

                                }
                                #endregion

                                StoreTab["#StoreBody"] = StoreBody;
                            }
                            #endregion
                            #region GuiContainer (UpdatesTab)        UpdatesTab
                            UpdatesTab = new ObjectCreator("GuiContainer", "UpdatesTab");
                            UpdatesTab["docking"] = "Client";
                            UpdatesTab["margin"] = "0 0 0 0";
                            UpdatesTab["padding"] = "0 0 0 0";
                            UpdatesTab["anchorTop"] = "1";
                            UpdatesTab["anchorBottom"] = "0";
                            UpdatesTab["anchorLeft"] = "1";
                            UpdatesTab["anchorRight"] = "0";
                            UpdatesTab["position"] = "0 0";
                            UpdatesTab["extent"] = "1186 616";
                            UpdatesTab["minExtent"] = "8 2";
                            UpdatesTab["maxExtent"] = "1920 1080";
                            UpdatesTab["horizSizing"] = "left";
                            UpdatesTab["vertSizing"] = "top";
                            UpdatesTab["profile"] = "GuiDefaultProfile";
                            UpdatesTab["controlFontColor"] = "0 0 0 0";
                            UpdatesTab["controlFillColor"] = "0 0 0 0";
                            UpdatesTab["backgroundColor"] = "255 255 255 255";
                            UpdatesTab["controlFontSize"] = "14";
                            UpdatesTab["visible"] = "0";
                            UpdatesTab["active"] = "1";
                            UpdatesTab["tooltipProfile"] = "GuiToolTipProfile";
                            UpdatesTab["hovertime"] = "1000";
                            UpdatesTab["isContainer"] = "1";
                            UpdatesTab["alphaValue"] = "1";
                            UpdatesTab["mouseOverAlphaValue"] = "1";
                            UpdatesTab["alphaFadeTime"] = "1000";
                            UpdatesTab["moveControl"] = "0";
                            UpdatesTab["lockControl"] = "0";
                            UpdatesTab["windowSettings"] = "1";
                            UpdatesTab["alpha"] = "1";
                            UpdatesTab["mouseOverAlpha"] = "1";
                            UpdatesTab["alphaFade"] = "1";
                            UpdatesTab["contextFontColor"] = "0";
                            UpdatesTab["contextBackColor"] = "0";
                            UpdatesTab["contextFillColor"] = "0";
                            UpdatesTab["contextFontSize"] = "0";
                            UpdatesTab["hidden"] = "1";
                            UpdatesTab["editable"] = "0";
                            UpdatesTab["canSave"] = "1";
                            UpdatesTab["canSaveDynamicFields"] = "0";
                            UpdatesTab["Enabled"] = "1";
                            if (true)
                            {
                                #region GuiContainer ()        UpdatesBody
                                UpdatesBody = new ObjectCreator("GuiContainer", "");
                                UpdatesBody["margin"] = "0 0 0 0";
                                UpdatesBody["padding"] = "0 0 0 0";
                                UpdatesBody["anchorTop"] = "1";
                                UpdatesBody["anchorBottom"] = "0";
                                UpdatesBody["anchorLeft"] = "1";
                                UpdatesBody["anchorRight"] = "0";
                                UpdatesBody["position"] = "40 166";
                                UpdatesBody["extent"] = "687 423";
                                UpdatesBody["minExtent"] = "8 2";
                                UpdatesBody["maxExtent"] = "1920 1080";
                                UpdatesBody["horizSizing"] = "right";
                                UpdatesBody["vertSizing"] = "bottom";
                                UpdatesBody["profile"] = "GuiDefaultProfile";
                                UpdatesBody["controlFontColor"] = "0 0 0 0";
                                UpdatesBody["controlFillColor"] = "0 0 0 0";
                                UpdatesBody["backgroundColor"] = "255 255 255 255";
                                UpdatesBody["controlFontSize"] = "-1";
                                UpdatesBody["visible"] = "1";
                                UpdatesBody["active"] = "1";
                                UpdatesBody["tooltipProfile"] = "GuiToolTipProfile";
                                UpdatesBody["hovertime"] = "1000";
                                UpdatesBody["isContainer"] = "1";
                                UpdatesBody["alphaValue"] = "1";
                                UpdatesBody["mouseOverAlphaValue"] = "1";
                                UpdatesBody["alphaFadeTime"] = "1000";
                                UpdatesBody["moveControl"] = "0";
                                UpdatesBody["lockControl"] = "0";
                                UpdatesBody["windowSettings"] = "1";
                                UpdatesBody["alpha"] = "1";
                                UpdatesBody["mouseOverAlpha"] = "1";
                                UpdatesBody["alphaFade"] = "1";
                                UpdatesBody["contextFontColor"] = "0";
                                UpdatesBody["contextBackColor"] = "0";
                                UpdatesBody["contextFillColor"] = "0";
                                UpdatesBody["contextFontSize"] = "0";
                                UpdatesBody["editable"] = "0";
                                UpdatesBody["canSave"] = "1";
                                UpdatesBody["canSaveDynamicFields"] = "0";
                                UpdatesBody["Enabled"] = "0";
                                if (true)
                                {

                                    #region GuiMLTextCtrl ()        UpdatesBodyText
                                    UpdatesBodyText = new ObjectCreator("GuiMLTextCtrl", "");
                                    UpdatesBodyText["lineSpacing"] = "2";
                                    UpdatesBodyText["allowColorChars"] = "0";
                                    UpdatesBodyText["maxChars"] = "-1";
                                    UpdatesBodyText["text"] = "Update Version 0.0.0:<br>JK not really";
                                    UpdatesBodyText["useURLMouseCursor"] = "0";
                                    UpdatesBodyText["position"] = "20 26";
                                    UpdatesBodyText["extent"] = "326 14";
                                    UpdatesBodyText["minExtent"] = "8 2";
                                    UpdatesBodyText["maxExtent"] = "1920 1080";
                                    UpdatesBodyText["horizSizing"] = "width";
                                    UpdatesBodyText["vertSizing"] = "bottom";
                                    UpdatesBodyText["profile"] = "GuiMLTextProfile";
                                    UpdatesBodyText["controlFontColor"] = "0 0 0 0";
                                    UpdatesBodyText["controlFillColor"] = "0 0 0 0";
                                    UpdatesBodyText["backgroundColor"] = "255 255 255 255";
                                    UpdatesBodyText["controlFontSize"] = "-1";
                                    UpdatesBodyText["visible"] = "1";
                                    UpdatesBodyText["active"] = "1";
                                    UpdatesBodyText["tooltipProfile"] = "GuiToolTipProfile";
                                    UpdatesBodyText["hovertime"] = "1000";
                                    UpdatesBodyText["isContainer"] = "0";
                                    UpdatesBodyText["alphaValue"] = "1";
                                    UpdatesBodyText["mouseOverAlphaValue"] = "1";
                                    UpdatesBodyText["alphaFadeTime"] = "1000";
                                    UpdatesBodyText["windowSettings"] = "1";
                                    UpdatesBodyText["alpha"] = "1";
                                    UpdatesBodyText["mouseOverAlpha"] = "1";
                                    UpdatesBodyText["alphaFade"] = "1";
                                    UpdatesBodyText["contextFontColor"] = "0";
                                    UpdatesBodyText["contextBackColor"] = "0";
                                    UpdatesBodyText["contextFillColor"] = "0";
                                    UpdatesBodyText["contextFontSize"] = "0";
                                    UpdatesBodyText["editable"] = "0";
                                    UpdatesBodyText["canSave"] = "1";
                                    UpdatesBodyText["canSaveDynamicFields"] = "0";
                                    UpdatesBodyText["Enabled"] = "0";
                                    #endregion

                                    UpdatesBody["#UpdatesBodyText"] = UpdatesBodyText;

                                }
                                #endregion

                                UpdatesTab["#UpdatesBody"] = UpdatesBody;
                            }
                            #endregion

                            ContentSection["#OptionsTab"] = OptionsTab;
                            ContentSection["#DevTab"] = DevTab;
                            ContentSection["#ServerTab"] = ServerTab;
                            ContentSection["#CommunityTab"] = CommunityTab;
                            ContentSection["#PrivateTab"] = PrivateTab;
                            ContentSection["#MatchmakingTab"] = MatchmakingTab;
                            ContentSection["#StoreTab"] = StoreTab;
                            ContentSection["#UpdatesTab"] = UpdatesTab;
                        }
                        #endregion

                        MenuItemHolder["#ContentSection"] = ContentSection;

                        #region GuiContainer (ButtonsSection)        ButtonsSection
                        ButtonsSection = new ObjectCreator("GuiContainer", "ButtonsSection");
                        ButtonsSection["docking"] = "Left";
                        ButtonsSection["margin"] = "0 0 0 0";
                        ButtonsSection["padding"] = "0 0 0 0";
                        ButtonsSection["anchorTop"] = "1";
                        ButtonsSection["anchorBottom"] = "1";
                        ButtonsSection["anchorLeft"] = "1";
                        ButtonsSection["anchorRight"] = "1";
                        ButtonsSection["position"] = "0 0";
                        ButtonsSection["extent"] = "175 616";
                        ButtonsSection["minExtent"] = "160 616";
                        ButtonsSection["maxExtent"] = "1920 1080";
                        ButtonsSection["horizSizing"] = "left";
                        ButtonsSection["vertSizing"] = "bottom";
                        ButtonsSection["profile"] = "GuiDefaultProfile";
                        ButtonsSection["controlFontColor"] = "0 0 0 0";
                        ButtonsSection["controlFillColor"] = "0 0 0 0";
                        ButtonsSection["backgroundColor"] = "255 255 255 255";
                        ButtonsSection["controlFontSize"] = "14";
                        ButtonsSection["visible"] = "1";
                        ButtonsSection["active"] = "1";
                        ButtonsSection["tooltipProfile"] = "GuiToolTipProfile";
                        ButtonsSection["hovertime"] = "1000";
                        ButtonsSection["isContainer"] = "1";
                        ButtonsSection["alphaValue"] = "1";
                        ButtonsSection["mouseOverAlphaValue"] = "1";
                        ButtonsSection["alphaFadeTime"] = "1000";
                        ButtonsSection["moveControl"] = "0";
                        ButtonsSection["lockControl"] = "0";
                        ButtonsSection["windowSettings"] = "1";
                        ButtonsSection["alpha"] = "1";
                        ButtonsSection["mouseOverAlpha"] = "1";
                        ButtonsSection["alphaFade"] = "1";
                        ButtonsSection["contextFontColor"] = "0";
                        ButtonsSection["contextBackColor"] = "0";
                        ButtonsSection["contextFillColor"] = "0";
                        ButtonsSection["contextFontSize"] = "0";
                        ButtonsSection["editable"] = "0";
                        ButtonsSection["canSave"] = "1";
                        ButtonsSection["canSaveDynamicFields"] = "0";
                        ButtonsSection["Enabled"] = "0";

                        if (true)
                        {

                            #region GuiBitmapCtrl ()        ButtonsSectionBg
                            ButtonsSectionBg = new ObjectCreator("GuiBitmapCtrl", "");
                            ButtonsSectionBg["bitmap"] = "art/gui/launcher/buttonbg.png";
                            ButtonsSectionBg["wrap"] = "0";
                            ButtonsSectionBg["setBitmap"] = "0";
                            ButtonsSectionBg["position"] = "0 0";
                            ButtonsSectionBg["extent"] = "175 616";
                            ButtonsSectionBg["minExtent"] = "8 2";
                            ButtonsSectionBg["maxExtent"] = "1920 1080";
                            ButtonsSectionBg["horizSizing"] = "relative";
                            ButtonsSectionBg["vertSizing"] = "bottom";
                            ButtonsSectionBg["profile"] = "GuiDefaultProfile";
                            ButtonsSectionBg["controlFontColor"] = "0 0 0 0";
                            ButtonsSectionBg["controlFillColor"] = "0 0 0 0";
                            ButtonsSectionBg["backgroundColor"] = "255 255 255 255";
                            ButtonsSectionBg["controlFontSize"] = "14";
                            ButtonsSectionBg["visible"] = "1";
                            ButtonsSectionBg["active"] = "1";
                            ButtonsSectionBg["tooltipProfile"] = "GuiToolTipProfile";
                            ButtonsSectionBg["hovertime"] = "1000";
                            ButtonsSectionBg["isContainer"] = "0";
                            ButtonsSectionBg["alphaValue"] = "1";
                            ButtonsSectionBg["mouseOverAlphaValue"] = "1";
                            ButtonsSectionBg["alphaFadeTime"] = "1000";
                            ButtonsSectionBg["moveControl"] = "0";
                            ButtonsSectionBg["lockControl"] = "0";
                            ButtonsSectionBg["windowSettings"] = "1";
                            ButtonsSectionBg["alpha"] = "1";
                            ButtonsSectionBg["mouseOverAlpha"] = "1";
                            ButtonsSectionBg["alphaFade"] = "1";
                            ButtonsSectionBg["contextFontColor"] = "0";
                            ButtonsSectionBg["contextBackColor"] = "0";
                            ButtonsSectionBg["contextFillColor"] = "0";
                            ButtonsSectionBg["contextFontSize"] = "0";
                            ButtonsSectionBg["editable"] = "0";
                            ButtonsSectionBg["canSave"] = "1";
                            ButtonsSectionBg["canSaveDynamicFields"] = "0";
                            ButtonsSectionBg["Enabled"] = "0";
                            #endregion

                            ButtonsSection["#ButtonsSectionBg"] = ButtonsSectionBg;

                            #region GuiBitmapButtonTextCtrl (UpdatesTabButton)        UpdatesTabButton
                            UpdatesTabButton = new ObjectCreator("GuiBitmapButtonTextCtrl", "UpdatesTabButton");
                            UpdatesTabButton["bitmap"] = "art/gui/launcher/updates_tab_unselected";
                            UpdatesTabButton["bitmapMode"] = "Centered";
                            UpdatesTabButton["autoFitExtents"] = "1";
                            UpdatesTabButton["useModifiers"] = "0";
                            UpdatesTabButton["useStates"] = "1";
                            UpdatesTabButton["groupNum"] = "-1";
                            UpdatesTabButton["buttonType"] = "PushButton";
                            UpdatesTabButton["useMouseEvents"] = "0";
                            UpdatesTabButton["position"] = "10 21";
                            UpdatesTabButton["extent"] = "154 44";
                            UpdatesTabButton["minExtent"] = "8 2";
                            UpdatesTabButton["maxExtent"] = "1920 1080";
                            UpdatesTabButton["horizSizing"] = "center";
                            UpdatesTabButton["vertSizing"] = "windowRelative";
                            UpdatesTabButton["profile"] = "GuiDefaultProfile";
                            UpdatesTabButton["controlFontColor"] = "0 0 0 0";
                            UpdatesTabButton["backgroundColor"] = "255 255 255 255";
                            UpdatesTabButton["controlFontSize"] = "14";
                            UpdatesTabButton["visible"] = "1";
                            UpdatesTabButton["active"] = "1";
                            UpdatesTabButton["command"] = "UpdatesTab.setVisible(true);DevTab.setVisible(false);ServerTab.setVisible(false);CommunityTab.setVisible(false);StoreTab.setVisible(false);PrivateTab.setVisible(false);MatchmakingTab.setVisible(false);OptionsTab.setVisible(false);";
                            UpdatesTabButton["tooltipProfile"] = "GuiToolTipProfile";
                            UpdatesTabButton["tooltip"] = "Updates";
                            UpdatesTabButton["hovertime"] = "1000";
                            UpdatesTabButton["isContainer"] = "0";
                            UpdatesTabButton["alphaValue"] = "1";
                            UpdatesTabButton["mouseOverAlphaValue"] = "1";
                            UpdatesTabButton["alphaFadeTime"] = "1000";
                            UpdatesTabButton["windowSettings"] = "1";
                            UpdatesTabButton["alpha"] = "1";
                            UpdatesTabButton["mouseOverAlpha"] = "1";
                            UpdatesTabButton["alphaFade"] = "1";
                            UpdatesTabButton["contextFontColor"] = "0";
                            UpdatesTabButton["contextBackColor"] = "0";
                            UpdatesTabButton["contextFontSize"] = "0";
                            UpdatesTabButton["editable"] = "0";
                            UpdatesTabButton["canSave"] = "1";
                            UpdatesTabButton["canSaveDynamicFields"] = "0";
                            UpdatesTabButton["Enabled"] = "1";
                            #endregion

                            ButtonsSection["#UpdatesTabButton"] = UpdatesTabButton;

                            #region GuiBitmapButtonTextCtrl (StoreTabButton)        StoreTabButton
                            StoreTabButton = new ObjectCreator("GuiBitmapButtonTextCtrl", "StoreTabButton");
                            StoreTabButton["bitmap"] = "art/gui/launcher/store_tab_unselected";
                            StoreTabButton["bitmapMode"] = "Centered";
                            StoreTabButton["autoFitExtents"] = "1";
                            StoreTabButton["useModifiers"] = "0";
                            StoreTabButton["useStates"] = "1";
                            StoreTabButton["groupNum"] = "-1";
                            StoreTabButton["buttonType"] = "PushButton";
                            StoreTabButton["useMouseEvents"] = "0";
                            StoreTabButton["position"] = "10 61";
                            StoreTabButton["extent"] = "154 44";
                            StoreTabButton["minExtent"] = "8 2";
                            StoreTabButton["maxExtent"] = "1920 1080";
                            StoreTabButton["horizSizing"] = "center";
                            StoreTabButton["vertSizing"] = "windowRelative";
                            StoreTabButton["profile"] = "GuiDefaultProfile";
                            StoreTabButton["controlFontColor"] = "0 0 0 0";
                            StoreTabButton["backgroundColor"] = "255 255 255 255";
                            StoreTabButton["controlFontSize"] = "14";
                            StoreTabButton["visible"] = "1";
                            StoreTabButton["active"] = "1";
                            StoreTabButton["command"] = "UpdatesTab.setVisible(false);DevTab.setVisible(false);ServerTab.setVisible(false);CommunityTab.setVisible(false);StoreTab.setVisible(true);PrivateTab.setVisible(false);MatchmakingTab.setVisible(false);OptionsTab.setVisible(false);";
                            StoreTabButton["tooltipProfile"] = "GuiToolTipProfile";
                            StoreTabButton["tooltip"] = "Store";
                            StoreTabButton["hovertime"] = "1000";
                            StoreTabButton["isContainer"] = "0";
                            StoreTabButton["alphaValue"] = "1";
                            StoreTabButton["mouseOverAlphaValue"] = "1";
                            StoreTabButton["alphaFadeTime"] = "1000";
                            StoreTabButton["windowSettings"] = "1";
                            StoreTabButton["alpha"] = "1";
                            StoreTabButton["mouseOverAlpha"] = "1";
                            StoreTabButton["alphaFade"] = "1";
                            StoreTabButton["contextFontColor"] = "0";
                            StoreTabButton["contextBackColor"] = "0";
                            StoreTabButton["contextFontSize"] = "0";
                            StoreTabButton["editable"] = "0";
                            StoreTabButton["canSave"] = "1";
                            StoreTabButton["canSaveDynamicFields"] = "0";
                            StoreTabButton["Enabled"] = "1";
                            #endregion

                            ButtonsSection["#StoreTabButton"] = StoreTabButton;

                            #region GuiBitmapButtonTextCtrl (MatchmakingTabButton)        MatchmakingTabButton
                            MatchmakingTabButton = new ObjectCreator("GuiBitmapButtonTextCtrl", "MatchmakingTabButton");
                            MatchmakingTabButton["bitmap"] = "art/gui/launcher/match_tab_unselected";
                            MatchmakingTabButton["bitmapMode"] = "Centered";
                            MatchmakingTabButton["autoFitExtents"] = "1";
                            MatchmakingTabButton["useModifiers"] = "0";
                            MatchmakingTabButton["useStates"] = "1";
                            MatchmakingTabButton["groupNum"] = "-1";
                            MatchmakingTabButton["buttonType"] = "PushButton";
                            MatchmakingTabButton["useMouseEvents"] = "0";
                            MatchmakingTabButton["position"] = "10 101";
                            MatchmakingTabButton["extent"] = "154 44";
                            MatchmakingTabButton["minExtent"] = "8 2";
                            MatchmakingTabButton["maxExtent"] = "1920 1080";
                            MatchmakingTabButton["horizSizing"] = "center";
                            MatchmakingTabButton["vertSizing"] = "windowRelative";
                            MatchmakingTabButton["profile"] = "GuiDefaultProfile";
                            MatchmakingTabButton["controlFontColor"] = "0 0 0 0";
                            MatchmakingTabButton["backgroundColor"] = "255 255 255 255";
                            MatchmakingTabButton["controlFontSize"] = "14";
                            MatchmakingTabButton["visible"] = "1";
                            MatchmakingTabButton["active"] = "1";
                            MatchmakingTabButton["command"] = "UpdatesTab.setVisible(false);DevTab.setVisible(false);ServerTab.setVisible(false);CommunityTab.setVisible(false);StoreTab.setVisible(false);PrivateTab.setVisible(false);MatchmakingTab.setVisible(true);OptionsTab.setVisible(false);";
                            MatchmakingTabButton["tooltipProfile"] = "GuiToolTipProfile";
                            MatchmakingTabButton["tooltip"] = "Matchmaking";
                            MatchmakingTabButton["hovertime"] = "1000";
                            MatchmakingTabButton["isContainer"] = "0";
                            MatchmakingTabButton["alphaValue"] = "1";
                            MatchmakingTabButton["mouseOverAlphaValue"] = "1";
                            MatchmakingTabButton["alphaFadeTime"] = "1000";
                            MatchmakingTabButton["windowSettings"] = "1";
                            MatchmakingTabButton["alpha"] = "1";
                            MatchmakingTabButton["mouseOverAlpha"] = "1";
                            MatchmakingTabButton["alphaFade"] = "1";
                            MatchmakingTabButton["contextFontColor"] = "0";
                            MatchmakingTabButton["contextBackColor"] = "0";
                            MatchmakingTabButton["contextFontSize"] = "0";
                            MatchmakingTabButton["editable"] = "0";
                            MatchmakingTabButton["canSave"] = "1";
                            MatchmakingTabButton["canSaveDynamicFields"] = "0";
                            MatchmakingTabButton["Enabled"] = "1";
                            #endregion

                            ButtonsSection["#MatchmakingTabButton"] = MatchmakingTabButton;

                            #region GuiBitmapButtonTextCtrl (PrivateTabButton)        PrivateTabButton
                            PrivateTabButton = new ObjectCreator("GuiBitmapButtonTextCtrl", "PrivateTabButton");
                            PrivateTabButton["bitmap"] = "art/gui/launcher/private_tab_unselected";
                            PrivateTabButton["bitmapMode"] = "Centered";
                            PrivateTabButton["autoFitExtents"] = "1";
                            PrivateTabButton["useModifiers"] = "0";
                            PrivateTabButton["useStates"] = "1";
                            PrivateTabButton["groupNum"] = "-1";
                            PrivateTabButton["buttonType"] = "PushButton";
                            PrivateTabButton["useMouseEvents"] = "0";
                            PrivateTabButton["position"] = "10 141";
                            PrivateTabButton["extent"] = "154 44";
                            PrivateTabButton["minExtent"] = "8 2";
                            PrivateTabButton["maxExtent"] = "1920 1080";
                            PrivateTabButton["horizSizing"] = "center";
                            PrivateTabButton["vertSizing"] = "windowRelative";
                            PrivateTabButton["profile"] = "GuiDefaultProfile";
                            PrivateTabButton["controlFontColor"] = "0 0 0 0";
                            PrivateTabButton["backgroundColor"] = "255 255 255 255";
                            PrivateTabButton["controlFontSize"] = "14";
                            PrivateTabButton["visible"] = "1";
                            PrivateTabButton["active"] = "1";
                            PrivateTabButton["command"] = "UpdatesTab.setVisible(false);DevTab.setVisible(false);ServerTab.setVisible(false);CommunityTab.setVisible(false);StoreTab.setVisible(false);PrivateTab.setVisible(true);MatchmakingTab.setVisible(false);OptionsTab.setVisible(false);";
                            PrivateTabButton["tooltipProfile"] = "GuiToolTipProfile";
                            PrivateTabButton["tooltip"] = "Private";
                            PrivateTabButton["hovertime"] = "1000";
                            PrivateTabButton["isContainer"] = "0";
                            PrivateTabButton["alphaValue"] = "1";
                            PrivateTabButton["mouseOverAlphaValue"] = "1";
                            PrivateTabButton["alphaFadeTime"] = "1000";
                            PrivateTabButton["windowSettings"] = "1";
                            PrivateTabButton["alpha"] = "1";
                            PrivateTabButton["mouseOverAlpha"] = "1";
                            PrivateTabButton["alphaFade"] = "1";
                            PrivateTabButton["contextFontColor"] = "0";
                            PrivateTabButton["contextBackColor"] = "0";
                            PrivateTabButton["contextFontSize"] = "0";
                            PrivateTabButton["editable"] = "0";
                            PrivateTabButton["canSave"] = "1";
                            PrivateTabButton["canSaveDynamicFields"] = "0";
                            PrivateTabButton["Enabled"] = "1";
                            #endregion

                            ButtonsSection["#PrivateTabButton"] = PrivateTabButton;

                            #region GuiBitmapButtonTextCtrl (CommunityTabButton)        CommunityTabButton
                            CommunityTabButton = new ObjectCreator("GuiBitmapButtonTextCtrl", "CommunityTabButton");
                            CommunityTabButton["bitmap"] = "art/gui/launcher/community_tab_unselected";
                            CommunityTabButton["bitmapMode"] = "Centered";
                            CommunityTabButton["autoFitExtents"] = "1";
                            CommunityTabButton["useModifiers"] = "0";
                            CommunityTabButton["useStates"] = "1";
                            CommunityTabButton["groupNum"] = "-1";
                            CommunityTabButton["buttonType"] = "PushButton";
                            CommunityTabButton["useMouseEvents"] = "0";
                            CommunityTabButton["position"] = "10 181";
                            CommunityTabButton["extent"] = "154 44";
                            CommunityTabButton["minExtent"] = "8 2";
                            CommunityTabButton["maxExtent"] = "1920 1080";
                            CommunityTabButton["horizSizing"] = "center";
                            CommunityTabButton["vertSizing"] = "windowRelative";
                            CommunityTabButton["profile"] = "GuiDefaultProfile";
                            CommunityTabButton["controlFontColor"] = "0 0 0 0";
                            CommunityTabButton["backgroundColor"] = "255 255 255 255";
                            CommunityTabButton["controlFontSize"] = "14";
                            CommunityTabButton["visible"] = "1";
                            CommunityTabButton["active"] = "1";
                            CommunityTabButton["command"] = "Canvas.pushDialog(ToolsDlg);UpdatesTab.setVisible(false);DevTab.setVisible(false);ServerTab.setVisible(false);CommunityTab.setVisible(true);StoreTab.setVisible(false);PrivateTab.setVisible(false);MatchmakingTab.setVisible(false);OptionsTab.setVisible(false);";
                            CommunityTabButton["tooltipProfile"] = "GuiToolTipProfile";
                            CommunityTabButton["tooltip"] = "Community";
                            CommunityTabButton["hovertime"] = "1000";
                            CommunityTabButton["isContainer"] = "0";
                            CommunityTabButton["alphaValue"] = "1";
                            CommunityTabButton["mouseOverAlphaValue"] = "1";
                            CommunityTabButton["alphaFadeTime"] = "1000";
                            CommunityTabButton["windowSettings"] = "1";
                            CommunityTabButton["alpha"] = "1";
                            CommunityTabButton["mouseOverAlpha"] = "1";
                            CommunityTabButton["alphaFade"] = "1";
                            CommunityTabButton["contextFontColor"] = "0";
                            CommunityTabButton["contextBackColor"] = "0";
                            CommunityTabButton["contextFontSize"] = "0";
                            CommunityTabButton["editable"] = "0";
                            CommunityTabButton["canSave"] = "1";
                            CommunityTabButton["canSaveDynamicFields"] = "0";
                            CommunityTabButton["Enabled"] = "1";
                            #endregion

                            ButtonsSection["#CommunityTabButton"] = CommunityTabButton;

                            #region GuiBitmapButtonTextCtrl (ServerTabButton)        ServerTabButton
                            ServerTabButton = new ObjectCreator("GuiBitmapButtonTextCtrl", "ServerTabButton");
                            ServerTabButton["bitmap"] = "art/gui/launcher/server_tab_unselected";
                            ServerTabButton["bitmapMode"] = "Centered";
                            ServerTabButton["autoFitExtents"] = "1";
                            ServerTabButton["useModifiers"] = "0";
                            ServerTabButton["useStates"] = "1";
                            ServerTabButton["groupNum"] = "-1";
                            ServerTabButton["buttonType"] = "PushButton";
                            ServerTabButton["useMouseEvents"] = "0";
                            ServerTabButton["position"] = "10 221";
                            ServerTabButton["extent"] = "154 44";
                            ServerTabButton["minExtent"] = "8 2";
                            ServerTabButton["maxExtent"] = "1920 1080";
                            ServerTabButton["horizSizing"] = "center";
                            ServerTabButton["vertSizing"] = "windowRelative";
                            ServerTabButton["profile"] = "GuiDefaultProfile";
                            ServerTabButton["controlFontColor"] = "0 0 0 0";
                            ServerTabButton["backgroundColor"] = "255 255 255 255";
                            ServerTabButton["controlFontSize"] = "14";
                            ServerTabButton["visible"] = "1";
                            ServerTabButton["active"] = "1";
                            ServerTabButton["command"] = "Canvas.pushDialog(JoinServerDlg);UpdatesTab.setVisible(false);DevTab.setVisible(false);ServerTab.setVisible(true);CommunityTab.setVisible(false);StoreTab.setVisible(false);PrivateTab.setVisible(false);MatchmakingTab.setVisible(false);OptionsTab.setVisible(false);";
                            ServerTabButton["tooltipProfile"] = "GuiToolTipProfile";
                            ServerTabButton["tooltip"] = "Server";
                            ServerTabButton["hovertime"] = "1000";
                            ServerTabButton["isContainer"] = "0";
                            ServerTabButton["alphaValue"] = "1";
                            ServerTabButton["mouseOverAlphaValue"] = "1";
                            ServerTabButton["alphaFadeTime"] = "1000";
                            ServerTabButton["windowSettings"] = "1";
                            ServerTabButton["alpha"] = "1";
                            ServerTabButton["mouseOverAlpha"] = "1";
                            ServerTabButton["alphaFade"] = "1";
                            ServerTabButton["contextFontColor"] = "0";
                            ServerTabButton["contextBackColor"] = "0";
                            ServerTabButton["contextFontSize"] = "0";
                            ServerTabButton["editable"] = "0";
                            ServerTabButton["canSave"] = "1";
                            ServerTabButton["canSaveDynamicFields"] = "0";
                            ServerTabButton["Enabled"] = "1";
                            #endregion

                            ButtonsSection["#ServerTabButton"] = ServerTabButton;

                            #region GuiBitmapButtonTextCtrl (OptionsTabButton)        OptionsTabButton
                            OptionsTabButton = new ObjectCreator("GuiBitmapButtonTextCtrl", "OptionsTabButton");
                            OptionsTabButton["bitmap"] = "art/gui/launcher/options_tab_unselected";
                            OptionsTabButton["bitmapMode"] = "Centered";
                            OptionsTabButton["autoFitExtents"] = "1";
                            OptionsTabButton["useModifiers"] = "0";
                            OptionsTabButton["useStates"] = "1";
                            OptionsTabButton["groupNum"] = "-1";
                            OptionsTabButton["buttonType"] = "PushButton";
                            OptionsTabButton["useMouseEvents"] = "0";
                            OptionsTabButton["position"] = "10 261";
                            OptionsTabButton["extent"] = "154 44";
                            OptionsTabButton["minExtent"] = "8 2";
                            OptionsTabButton["maxExtent"] = "1920 1080";
                            OptionsTabButton["horizSizing"] = "center";
                            OptionsTabButton["vertSizing"] = "windowRelative";
                            OptionsTabButton["profile"] = "GuiDefaultProfile";
                            OptionsTabButton["controlFontColor"] = "0 0 0 0";
                            OptionsTabButton["backgroundColor"] = "255 255 255 255";
                            OptionsTabButton["controlFontSize"] = "14";
                            OptionsTabButton["visible"] = "1";
                            OptionsTabButton["active"] = "1";
                            OptionsTabButton["command"] = "Canvas.pushDialog(optionsDlg);UpdatesTab.setVisible(false);DevTab.setVisible(false);ServerTab.setVisible(false);CommunityTab.setVisible(false);StoreTab.setVisible(false);PrivateTab.setVisible(false);MatchmakingTab.setVisible(false);OptionsTab.setVisible(true);";
                            OptionsTabButton["tooltipProfile"] = "GuiToolTipProfile";
                            OptionsTabButton["tooltip"] = "Options";
                            OptionsTabButton["hovertime"] = "1000";
                            OptionsTabButton["isContainer"] = "0";
                            OptionsTabButton["alphaValue"] = "1";
                            OptionsTabButton["mouseOverAlphaValue"] = "1";
                            OptionsTabButton["alphaFadeTime"] = "1000";
                            OptionsTabButton["windowSettings"] = "1";
                            OptionsTabButton["alpha"] = "1";
                            OptionsTabButton["mouseOverAlpha"] = "1";
                            OptionsTabButton["alphaFade"] = "1";
                            OptionsTabButton["contextFontColor"] = "0";
                            OptionsTabButton["contextBackColor"] = "0";
                            OptionsTabButton["contextFontSize"] = "0";
                            OptionsTabButton["editable"] = "0";
                            OptionsTabButton["canSave"] = "1";
                            OptionsTabButton["canSaveDynamicFields"] = "0";
                            OptionsTabButton["Enabled"] = "1";
                            #endregion

                            ButtonsSection["#OptionsTabButton"] = OptionsTabButton;

                            #region GuiBitmapButtonTextCtrl (QuitTabButton)        QuitTabButton
                            QuitTabButton = new ObjectCreator("GuiBitmapButtonTextCtrl", "QuitTabButton");
                            QuitTabButton["bitmap"] = "art/gui/launcher/quit_tab_unselected";
                            QuitTabButton["bitmapMode"] = "Centered";
                            QuitTabButton["autoFitExtents"] = "1";
                            QuitTabButton["useModifiers"] = "0";
                            QuitTabButton["useStates"] = "1";
                            QuitTabButton["groupNum"] = "-1";
                            QuitTabButton["buttonType"] = "PushButton";
                            QuitTabButton["useMouseEvents"] = "0";
                            QuitTabButton["position"] = "10 381";
                            QuitTabButton["extent"] = "154 44";
                            QuitTabButton["minExtent"] = "8 2";
                            QuitTabButton["maxExtent"] = "1920 1080";
                            QuitTabButton["horizSizing"] = "center";
                            QuitTabButton["vertSizing"] = "windowRelative";
                            QuitTabButton["profile"] = "GuiDefaultProfile";
                            QuitTabButton["controlFontColor"] = "0 0 0 0";
                            QuitTabButton["backgroundColor"] = "255 255 255 255";
                            QuitTabButton["controlFontSize"] = "14";
                            QuitTabButton["visible"] = "1";
                            QuitTabButton["active"] = "1";
                            QuitTabButton["command"] = "quit();";
                            QuitTabButton["tooltipProfile"] = "GuiToolTipProfile";
                            QuitTabButton["tooltip"] = "Quit";
                            QuitTabButton["hovertime"] = "1000";
                            QuitTabButton["isContainer"] = "0";
                            QuitTabButton["alphaValue"] = "1";
                            QuitTabButton["mouseOverAlphaValue"] = "1";
                            QuitTabButton["alphaFadeTime"] = "1000";
                            QuitTabButton["windowSettings"] = "1";
                            QuitTabButton["alpha"] = "1";
                            QuitTabButton["mouseOverAlpha"] = "1";
                            QuitTabButton["alphaFade"] = "1";
                            QuitTabButton["contextFontColor"] = "0";
                            QuitTabButton["contextBackColor"] = "0";
                            QuitTabButton["contextFontSize"] = "0";
                            QuitTabButton["editable"] = "0";
                            QuitTabButton["canSave"] = "1";
                            QuitTabButton["canSaveDynamicFields"] = "0";
                            QuitTabButton["Enabled"] = "1";
                            #endregion

                            ButtonsSection["#QuitTabButton"] = QuitTabButton;

                            #region GuiBitmapButtonTextCtrl (DevTabButton)        DevTabButton
                            DevTabButton = new ObjectCreator("GuiBitmapButtonTextCtrl", "DevTabButton");
                            DevTabButton["bitmap"] = "art/gui/launcher/dev_tab_unselected";
                            DevTabButton["bitmapMode"] = "Centered";
                            DevTabButton["autoFitExtents"] = "1";
                            DevTabButton["useModifiers"] = "0";
                            DevTabButton["useStates"] = "1";
                            DevTabButton["groupNum"] = "-1";
                            DevTabButton["buttonType"] = "PushButton";
                            DevTabButton["useMouseEvents"] = "0";
                            DevTabButton["position"] = "10 341";
                            DevTabButton["extent"] = "154 44";
                            DevTabButton["minExtent"] = "8 2";
                            DevTabButton["maxExtent"] = "1920 1080";
                            DevTabButton["horizSizing"] = "center";
                            DevTabButton["vertSizing"] = "windowRelative";
                            DevTabButton["profile"] = "GuiDefaultProfile";
                            DevTabButton["controlFontColor"] = "0 0 0 0";
                            DevTabButton["backgroundColor"] = "255 255 255 255";
                            DevTabButton["controlFontSize"] = "14";
                            DevTabButton["visible"] = "1";
                            DevTabButton["active"] = "1";
                            DevTabButton["command"] = "UpdatesTab.setVisible(false);DevTab.setVisible(true);ServerTab.setVisible(false);CommunityTab.setVisible(false);StoreTab.setVisible(false);PrivateTab.setVisible(false);MatchmakingTab.setVisible(false);OptionsTab.setVisible(false);";
                            DevTabButton["tooltipProfile"] = "GuiToolTipProfile";
                            DevTabButton["tooltip"] = "Dev";
                            DevTabButton["hovertime"] = "1000";
                            DevTabButton["isContainer"] = "0";
                            DevTabButton["alphaValue"] = "1";
                            DevTabButton["mouseOverAlphaValue"] = "1";
                            DevTabButton["alphaFadeTime"] = "1000";
                            DevTabButton["windowSettings"] = "1";
                            DevTabButton["alpha"] = "1";
                            DevTabButton["mouseOverAlpha"] = "1";
                            DevTabButton["alphaFade"] = "1";
                            DevTabButton["contextFontColor"] = "0";
                            DevTabButton["contextBackColor"] = "0";
                            DevTabButton["contextFontSize"] = "0";
                            DevTabButton["editable"] = "0";
                            DevTabButton["canSave"] = "1";
                            DevTabButton["canSaveDynamicFields"] = "0";
                            DevTabButton["Enabled"] = "1";
                            #endregion

                            ButtonsSection["#DevTabButton"] = DevTabButton;
                        }
                        #endregion

                        MenuItemHolder["#ButtonsSection"] = ButtonsSection;
                    }
                    #endregion

                    #region GuiControl (ChooseLevelDlg)        oc_Newobject00021

                    oc_Newobject00021 = new ObjectCreator("GuiControl", "ChooseLevelDlg", typeof(chooseLevelDlg));
                    oc_Newobject00021["position"] = "357 60";
                    oc_Newobject00021["extent"] = "659 692";
                    oc_Newobject00021["minExtent"] = "8 2";
                    oc_Newobject00021["maxExtent"] = "1920 1080";
                    oc_Newobject00021["horizSizing"] = "right";
                    oc_Newobject00021["vertSizing"] = "bottom";
                    oc_Newobject00021["profile"] = "GuiDefaultProfile";
                    oc_Newobject00021["controlFontColor"] = "0 0 0 0";
                    oc_Newobject00021["controlFillColor"] = "0 0 0 0";
                    oc_Newobject00021["backgroundColor"] = "255 255 255 255";
                    oc_Newobject00021["controlFontSize"] = "14";
                    oc_Newobject00021["visible"] = "1";
                    oc_Newobject00021["active"] = "1";
                    oc_Newobject00021["tooltipProfile"] = "GuiToolTipProfile";
                    oc_Newobject00021["hovertime"] = "1000";
                    oc_Newobject00021["isContainer"] = "1";
                    oc_Newobject00021["alphaValue"] = "1";
                    oc_Newobject00021["mouseOverAlphaValue"] = "1";
                    oc_Newobject00021["alphaFadeTime"] = "1000";
                    oc_Newobject00021["moveControl"] = "0";
                    oc_Newobject00021["lockControl"] = "0";
                    oc_Newobject00021["windowSettings"] = "1";
                    oc_Newobject00021["alpha"] = "1";
                    oc_Newobject00021["mouseOverAlpha"] = "1";
                    oc_Newobject00021["alphaFade"] = "1";
                    oc_Newobject00021["contextFontColor"] = "0";
                    oc_Newobject00021["contextBackColor"] = "0";
                    oc_Newobject00021["contextFillColor"] = "0";
                    oc_Newobject00021["contextFontSize"] = "0";
                    oc_Newobject00021["editable"] = "0";
                    oc_Newobject00021["canSave"] = "1";
                    oc_Newobject00021["canSaveDynamicFields"] = "0";
                    oc_Newobject00021["Enabled"] = "1";
                    if (true)
                    {
                    }

                    #endregion

                    BackgroundImage["#Newobject00021"] = oc_Newobject00021;
                    BackgroundImage["#LogoImage"] = LogoImage;
                    BackgroundImage["#MenuItemHolder"] = MenuItemHolder;
                }

                #endregion

                BackgroundImage.Create();
            }
        }

        public override void onWake()
        {
            ((GuiCheckBoxCtrl)this.FOT("PlayButton")).setStateOn(true);
            if (Util.getWebDeployment() && this.FOT("ExitButton").isObject())
                ((GuiButtonCtrl)this.FOT("ExitButton")).setVisible(false);
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        ///
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(mainMenuGui ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(mainMenuGui ts, string simobjectid)
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
        public static implicit operator string(mainMenuGui ts)
        {
            if (ReferenceEquals(ts, null))
                return "0";
            return ts._ID;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator mainMenuGui(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (mainMenuGui)Omni.self.getSimObject(simobjectid, typeof(mainMenuGui));
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(mainMenuGui ts)
        {
            return (int)ts._iID;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator mainMenuGui(int simobjectid)
        {
            return (mainMenuGui)Omni.self.getSimObject((uint)simobjectid, typeof(mainMenuGui));
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(mainMenuGui ts)
        {
            return ts._iID;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public static implicit operator mainMenuGui(uint simobjectid)
        {
            return (mainMenuGui)Omni.self.getSimObject(simobjectid, typeof(mainMenuGui));
        }

        #endregion
    }
}

