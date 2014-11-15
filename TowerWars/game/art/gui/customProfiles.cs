//-----------------------------------------------------------------------------
// Copyright (c) 2012 GarageGames, LLC
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
//-----------------------------------------------------------------------------

// ----------------------------------------------------------------------------
// This is the default save location for any GuiProfiles created in the
// Gui Editor
// ----------------------------------------------------------------------------


singleton GuiControlProfile(CMenuTabBg : CMenuTab)
{
   fillColor = "74 165 231 255";
};

singleton GuiControlProfile(CTab : GuiTabPageProfile)
{
   fillColor = "22 22 22 255";
   fillColorHL = "0 119 255 255";
   fillColorNA = "255 0 36 255";
   opaque = "1";
   fontSize = "20";
   fontType = "Impact";
};

singleton GuiControlProfile(CTabContainer : CTab)
{
   fillColor = "131 136 124 255";
   fontType = "Impact";
   fontColors[0] = "41 41 49 255";
   fontColor = "41 41 49 255";
};

singleton GuiControlProfile(CContentBackgroundB : CContentBackground)
{
   fillColor = "49 49 49 255";
};

singleton GuiControlProfile(CContentBackground : CTabContainer)
{
   fillColor = "135 135 134 255";
};

singleton GuiControlProfile(CContentPanelTitle)
{
   fontType = "Impact";
   category = "Core";
   fontSize = "30";
   justify = "Center";
   fontColors[0] = "215 215 215 255";
   fontColor = "215 215 215 255";
};
