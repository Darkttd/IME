﻿using System;
using System.Collections.Generic;
using System.Text;
using TSF.InteropTypes;
using TSF.TypeLib;

namespace SampleIMESharp
{
    partial class SampleIME : ITfTextEditSink
    {
        HRESULT ITfTextEditSink.OnEndEdit(ITfContext pic, uint ecReadOnly, ITfEditRecord pEditRecord)
        {
            throw new NotImplementedException();
        }
    }
}
