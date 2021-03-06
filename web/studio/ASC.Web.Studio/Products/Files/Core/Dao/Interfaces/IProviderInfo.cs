/* 
 * 
 * (c) Copyright Ascensio System Limited 2010-2014
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Affero General Public License as
 * published by the Free Software Foundation, either version 3 of the
 * License, or (at your option) any later version.
 * 
 * http://www.gnu.org/licenses/agpl.html 
 * 
 */

using System;

namespace ASC.Files.Core
{
    public interface IProviderInfo
    {
        int ID { get; set; }
        string ProviderKey { get; }
        Guid Owner { get; }
        FolderType RootFolderType { get; }
        DateTime CreateOn { get; }
        string CustomerTitle { get; }

        object RootFolderId { get; }

        bool CheckAccess();
        void InvalidateStorage();
    }
}