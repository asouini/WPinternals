﻿// Copyright (c) 2018, Rene Lergner - wpinternals.net - @Heathcliff74xda
//
// Permission is hereby granted, free of charge, to any person obtaining a
// copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.

using System;

namespace WPinternals
{
    internal class GettingStartedViewModel : ContextViewModel
    {
        internal Action ShowDisclaimer;
        internal Action SwitchToUnlockBoot;
        internal Action SwitchToUnlockRoot;
        internal Action SwitchToBackup;
        internal Action SwitchToDumpRom;
        internal Action SwitchToFlashRom;
        internal Action SwitchToDownload;

        internal GettingStartedViewModel(Action ShowDisclaimer, Action SwitchToUnlockBoot, Action SwitchToUnlockRoot, Action SwitchToBackup, Action SwitchToDumpRom, Action SwitchToFlashRom, Action SwitchToDownload)
            : base()
        {
            this.ShowDisclaimer = ShowDisclaimer;
            this.SwitchToUnlockBoot = SwitchToUnlockBoot;
            this.SwitchToUnlockRoot = SwitchToUnlockRoot;
            this.SwitchToBackup = SwitchToBackup;
            this.SwitchToFlashRom = SwitchToFlashRom;
            this.SwitchToDumpRom = SwitchToDumpRom;
            this.SwitchToDownload = SwitchToDownload;
        }
    }
}
