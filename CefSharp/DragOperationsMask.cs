﻿// Copyright © 2010-2014 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.


using System;

namespace CefSharp
{
    [Flags]
    public enum DragOperationsMask
    {
        None = 0,
        Copy = 1,
        Link = 2,
        Generic = 4, 
        Private = 8, 
        Move = 16, 
        Delete = 32,
        Every = None | Copy | Link | Generic | Private | Move | Delete
    } 
}
