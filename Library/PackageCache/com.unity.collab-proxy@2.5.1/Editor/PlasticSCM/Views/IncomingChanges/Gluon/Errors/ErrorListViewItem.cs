﻿using UnityEditor.IMGUI.Controls;

using Codice.CM.Common;

namespace Unity.PlasticSCM.Editor.Views.IncomingChanges.Gluon.Errors
{
    internal class ErrorListViewItem : TreeViewItem
    {
        internal ErrorMessage ErrorMessage { get; private set; }

        internal ErrorListViewItem(int id, ErrorMessage errorMessage)
            : base(id, 0)
        {
            ErrorMessage = errorMessage;

            displayName = errorMessage.Path;
        }
    }
}
